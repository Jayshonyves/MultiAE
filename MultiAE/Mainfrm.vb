Imports Microsoft.Win32
Imports System.IO

Public Class Mainfrm
    Private aeProcess() As Process
    Public Shared ProjectFolder As String
    Enum RenderMode
        RenderAEP
        RenderWF
    End Enum
    Private RenderM As RenderMode = RenderMode.RenderAEP
    Private Sub SchAEBtn_Click(sender As Object, e As EventArgs) Handles SchAEBtn.Click
        AEPath.Items.Clear()
        Dim dd() As String = GetAEPath()
        For Each d As String In dd
            AEPath.Items.Add(d)
            AEPath.Text = d
            debugfrm.debugOut(d)
        Next
    End Sub

    ''' <summary>
    ''' 获取AE路径
    ''' </summary>
    ''' <returns></returns>
    Private Function GetAEPath() As String()
        Dim HKLM As RegistryKey = Registry.LocalMachine
        Dim subkey As RegistryKey = HKLM.OpenSubKey("SOFTWARE\Adobe\After Effects")
        If IsNothing(subkey) Then
            Return Nothing
        Else
            Dim insAE() As String = subkey.GetSubKeyNames()
            Dim rtn(insAE.Length - 1) As String
            For i As Integer = 0 To insAE.Length - 1
                rtn(i) = subkey.OpenSubKey(insAE(i)).GetValue("InstallPath")
                If Not rtn(i).EndsWith("\") Then
                    rtn(i) += "\"
                End If
            Next i
            Return rtn
        End If
    End Function

    Private Sub CheckAEPath_Click(sender As Object, e As EventArgs) Handles CheckAEPath.Click
        Dim fb As New FolderBrowserDialog
        fb.ShowDialog()

        If fb.SelectedPath <> "" Then
            AEPath.Text = fb.SelectedPath & "\"
        End If

    End Sub

    Private Sub Mainfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim existConfig As Boolean = Module1.Init()
        If existConfig Then
            AEPath.Text = Config.AePath
            With RenderSettingC
                .Text = Config.CurRenderSetting
                .Items.Clear()
                .Items.AddRange(Config.RenderSetting.ToArray)
            End With
            With OutputModuleC
                .Text = Config.CurOutputModule
                .Items.Clear()
                .Items.AddRange(Config.OutputModule.ToArray)
            End With
            ThreadNum.Text = Config.ThreadCount
            TopWindowCheck.Checked = Config.WindowTop
            Me.TopMost = Config.WindowTop
            RenderDoneShutDown.Checked = Config.CompleteShutdown
            ShowRenderCK.Checked = Config.DisplayConsole
            OnlyShowOneCK.Checked = Config.OnlyConsole
            RenderDoneCk.Checked = Config.CompleteNotify
        End If

        VerShowL.Text += Ver
        WatchFolder.Text = Command()

        Dim tip As New ToolTip With {
            .AutoPopDelay = 30000,
            .InitialDelay = 10,
            .ToolTipTitle = "渲染关机注意"
        }
        tip.SetToolTip(RenderDoneShutDown, "即使渲染错误也会判定为渲染完成，这个选项会在渲染结束后判定" & vbCrLf &
                       "如果渲染已经开始，在结束之前还可以对此选项进行更改" & vbCrLf &
                       "关机操作有可能会被部分杀毒软件拦截，如想使用本功能最好关闭杀软" & vbCrLf &
                       "在渲染完成结束后的一段时间内（60秒）会进入关机倒计时" & vbCrLf &
                       "此时在这个面板上会有一个取消关机的按钮可供选择"
        )

        VerShowL.Text = "MultiAERenderVer" & Ver
        Dim forceStoptip As New ToolTip With {
            .AutomaticDelay = 30000,
            .InitialDelay = 10,
            .ToolTipTitle = "注意（慎用）"
        }
        forceStoptip.SetToolTip(ForceStopALL, "停止全部AE相关进程")

        Dim tip_addrender As New ToolTip With {
            .AutomaticDelay = 30000,
            .InitialDelay = 10,
            .ToolTipTitle = "注意"
        }
        tip_addrender.SetToolTip(RunScriptsBtn, "")


        Me.Text = "AE多开多线程渲染工具 - MultiAERenderV" & Ver
        debugfrm.debugOut("Ver - " & Ver & " " & verDate)
        debugfrm.debugOut("Initialize..")
        Call SchAEBtn_Click(sender, e)
        debugfrm.Show()
    End Sub
    Private Sub postdone(s As String)
        useCount = s
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.imxqy.com/program/multiaerender.html")
    End Sub
    Private Function GetAllFile(ByVal strDirect As String) As String()
        watchaepfiles.Clear()
        GetAllFiles(strDirect)
        Return watchaepfiles.ToArray
    End Function
    Private watchaepfiles As List(Of String) = New List(Of String)
    Private Sub addfile(st As String)
        watchaepfiles.Add(st)
    End Sub
    Private Sub GetAllFiles(ByVal strDirect As String)
        If Not (strDirect Is Nothing) Then
            Dim mFileInfo As System.IO.FileInfo
            Dim mDir As System.IO.DirectoryInfo
            Dim mDirInfo As New System.IO.DirectoryInfo(strDirect)
            Try
                For Each mFileInfo In mDirInfo.GetFiles("*.aep")
                    addfile(mFileInfo.FullName)
                Next

                For Each mDir In mDirInfo.GetDirectories
                    GetAllFiles(mDir.FullName)
                Next
            Catch ex As System.IO.DirectoryNotFoundException
                Debug.Print("目录没找到：" + ex.Message)
            End Try
        End If
    End Sub

    Private Sub StartRenderBtn_Click(sender As Object, e As EventArgs) Handles StartRenderBtn.Click
        If Not Directory.Exists(AEPath.Text) Then MsgBox("AE路径不正确") : Exit Sub
        If RenderM = RenderMode.RenderWF Then
            If Not Directory.Exists(WatchFolder.Text) Then MsgBox("项目路径不正确") : Exit Sub
        ElseIf RenderM = RenderMode.RenderAEP Then
            If Not File.Exists(WatchFolder.Text) Then MsgBox("文件路径不正确") : Exit Sub
        End If
        'If Not Directory.Exists(RenderFolder.Text) Then MsgBox("渲染路径不正确") : Exit Sub
        Dim tn As Integer = Val(ThreadNum.Text)
        If tn < 1 Then MsgBox("线程数不能为0和小于0") : Exit Sub

        ProjectFolder = WatchFolder.Text

        RenderStatL.Text = "正在渲染..."
        '开始渲染作业
        ReDim aeProcess(tn - 1)
        For i As Integer = 0 To tn - 1
            If RenderM = RenderMode.RenderAEP Then
                'AEP
                Dim pi As New ProcessStartInfo With {
                    .FileName = AEPath.Text & "aerender.exe",
                    .Arguments = "-project " & Chr(34) & WatchFolder.Text & Chr(34)
                }

                If Not ShowRenderCK.Checked Then
                    pi.WindowStyle = ProcessWindowStyle.Hidden
                Else
                    If OnlyShowOneCK.Checked Then
                        If i <> 0 Then pi.WindowStyle = ProcessWindowStyle.Hidden
                    End If
                End If

                debugfrm.debugOut("StartRenderThread:" & i)
                aeProcess(i) = Process.Start(pi)
            ElseIf RenderM = RenderMode.RenderWF Then
                'WF
                Dim st() As String = GetAllFile(WatchFolder.Text)
                For Each ii As String In st
                    Dim p As String = Path.GetDirectoryName(ii) & "\" & Path.GetFileNameWithoutExtension(ii) & "_RCF.txt"

                    Dim writeData(6) As String
                    writeData(0) = "After Effects 13.2v1 Render Control File"
                    writeData(1) = "max_machines=" & aeProcess.Length
                    writeData(2) = "num_machines=0"
                    writeData(3) = "init=0"
                    writeData(4) = "html_init=0"
                    writeData(5) = "html_name="""""

                    File.WriteAllLines(p, writeData)
                Next

                debugfrm.debugOut("StartRenderThread:" & i)
                aeProcess(i) = Process.Start(AEPath.Text & "AfterFX.exe", "-re -m -wf " & Chr(34) & WatchFolder.Text & Chr(34))
            End If
        Next i

        Timer1.Enabled = True

        StartRenderBtn.Enabled = False
        StopALLBtn.Enabled = True
        ForceStopALL.Enabled = True

    End Sub

    Private Sub UseInc_Click(sender As Object, e As EventArgs) Handles UseInc.Click
        System.Diagnostics.Process.Start("http://www.imxqy.com/info/soft/multiaerender.html")
    End Sub

    Private Sub StopALLBtn_Click(sender As Object, e As EventArgs) Handles StopALLBtn.Click
        Timer1.Enabled = False
        'RenderDoneCk.Checked = False
        RenderStatL.Text = "全部停止."
        Try
            For i As Integer = 0 To aeProcess.Length - 1
                aeProcess(i).Kill()
                'aeProcess(i).Id
            Next
        Catch ex As Exception

        End Try
        StartRenderBtn.Enabled = True
        StopALLBtn.Enabled = False
        ForceStopALL.Enabled = False
    End Sub

    Private Sub FindWatchFolder_Click(sender As Object, e As EventArgs) Handles FindWatchFolder.Click
        If RenderM = RenderMode.RenderWF Then
            Dim fbd1 As New FolderBrowserDialog
            fbd1.ShowDialog()
            If fbd1.SelectedPath <> "" Then WatchFolder.Text = fbd1.SelectedPath
        ElseIf RenderM = RenderMode.RenderAEP Then
            Dim fd As New OpenFileDialog
            fd.Filter = "|*.aep"
            fd.ShowDialog()
            If fd.FileName <> "" Then WatchFolder.Text = fd.FileName
        End If
    End Sub

    Private Sub ProFrm_Click(sender As Object, e As EventArgs) Handles ProFrm.Click
        If RenderM = RenderMode.RenderWF Then
            WatchFrm.Show()
        ElseIf RenderM = RenderMode.RenderAEP Then
            'RenderLogFrm.Show()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        WatchFolder.Text = ""
        If ComboBox1.Text = "直接渲染单工程" Then
            RenderM = RenderMode.RenderAEP
            RenderModeL.Text = "渲染单工程文件"
            RenderModeL2.Text = "选择aep工程文件"

            ProFrm.Enabled = False
            RenderDoneCk.Enabled = True
            ShowRenderCK.Enabled = True
            OnlyShowOneCK.Enabled = True
        Else
            RenderM = RenderMode.RenderWF
            RenderModeL.Text = "渲染监视工程"
            RenderModeL2.Text = "选择打包后的工程文件夹"
            ProFrm.Enabled = True
            RenderDoneCk.Enabled = False
            ShowRenderCK.Enabled = False
            OnlyShowOneCK.Enabled = False
        End If
    End Sub

    Private Sub LB_DragDrop(sender As Object, e As DragEventArgs) Handles LB.DragDrop
        For Each s As String In e.Data.GetData(DataFormats.FileDrop) '循环枚举数据
            WatchFolder.Text = s '添加到表
        Next
    End Sub

    Private Sub WatchFolder_DragDrop(sender As Object, e As DragEventArgs) Handles WatchFolder.DragDrop
        For Each s As String In e.Data.GetData(DataFormats.FileDrop) '循环枚举数据
            WatchFolder.Text = s '添加到表
        Next
    End Sub

    Private Sub LB_DragEnter(sender As Object, e As DragEventArgs) Handles LB.DragEnter
        e.Effect = DragDropEffects.Link '接受拖放数据，启用拖放效果
    End Sub

    Private Sub WatchFolder_DragEnter(sender As Object, e As DragEventArgs) Handles WatchFolder.DragEnter
        e.Effect = DragDropEffects.Link '接受拖放数据，启用拖放效果
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ad As Integer = 0
        For i As Integer = 0 To aeProcess.Length - 1
            If Not aeProcess(i).HasExited Then ad += 1
            debugfrm.debugOut("RenderThread" & i & "Rendering" & " : " & Not aeProcess(i).HasExited)
        Next
        '运行结束
        debugfrm.debugOut("RenderingThread:" & ad & "/" & aeProcess.Length)
        If ad = 0 Then
            '通知
            If RenderDoneCk.Checked Then
                Dim sm As Stream = My.Resources.Resource1.ddl
                My.Computer.Audio.Play(sm, AudioPlayMode.Background)
            End If
            StopALLBtn.Enabled = False
            ForceStopALL.Enabled = False
            StartRenderBtn.Enabled = True
            RenderStatL.Text = "渲染完成."
            If RenderDoneShutDown.Checked Then
                Shell("cmd /c shutdown /s /t 60 /c 渲染已完成，计算机将在60后关闭")
                CancelShutdown.Enabled = True
            End If
            Timer1.Enabled = False
        End If
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        System.Diagnostics.Process.Start("http://www.imxqy.com/info/soft/aebatchrender.html")
    End Sub

    Private Sub ShowRenderCK_CheckedChanged(sender As Object, e As EventArgs) Handles ShowRenderCK.CheckedChanged
        If ShowRenderCK.Checked Then
            OnlyShowOneCK.Enabled = True
        Else
            OnlyShowOneCK.Enabled = False
        End If
    End Sub

    Private Sub CancelShutdown_Click(sender As Object, e As EventArgs) Handles CancelShutdown.Click
        Shell("cmd /c shutdown /a")
        CancelShutdown.Enabled = False
    End Sub

    Private Sub ForceStopALL_Click(sender As Object, e As EventArgs) Handles ForceStopALL.Click
        For i As Integer = 0 To aeProcess.Length
            Shell("cmd /c taskkill /f /im AfterFX.exe && taskkill /f /im aerender.exe")
        Next
        ForceStopALL.Enabled = False
        StopALLBtn.Enabled = False
        StartRenderBtn.Enabled = True
    End Sub

    Private Sub OpenAEBtn_Click(sender As Object, e As EventArgs) Handles OpenAEBtn.Click
        If File.Exists(AEPath.Text & "AfterFX.exe") Then
            Process.Start(AEPath.Text & "AfterFX.exe")
        Else
            MsgBox("路径错误")
        End If
    End Sub

    Private Sub CMDBtn_Click(sender As Object, e As EventArgs) Handles CMDBtn.Click
        Dim pi As New Process()
        pi.StartInfo.FileName = "cmd.exe"
        pi.StartInfo.WorkingDirectory = AEPath.Text
        pi.Start()
    End Sub

    Private Sub AERenderEngineBtn_Click(sender As Object, e As EventArgs) Handles AERenderEngineBtn.Click
        If File.Exists(AEPath.Text & "AfterFX.exe") Then
            Process.Start(AEPath.Text & "AfterFX.exe", "-re")
        Else
            MsgBox("路径错误")
        End If
    End Sub

    Private Sub TestConnBtn_Click(sender As Object, e As EventArgs) Handles TestConnBtn.Click
        If File.Exists(AEPath.Text & "AfterFX.exe") Then
            Dim cmdl = "-s alert(""MultiAERender测试连接" &
                          "\nAE版本为"" + app.version + " &
                          """\n当前语言为"" + app.isoLanguage + " &
                          """\n是否已渲染引擎方式运行"" + app.isRenderEngine + " &
                          """\n是否已监视方式运行"" + app.isWatchFolder +" &
                          """\n正在AE使用的内存量"" + app.memoryInUse" &
                          ",""After Effect连接测试"");"
            Process.Start(AEPath.Text & "AfterFX.exe", cmdl)
        Else
            MsgBox("路径错误")
        End If
    End Sub

    Private Sub RunScriptsBtn_Click(sender As Object, e As EventArgs) Handles RunScriptsBtn.Click
        If File.Exists(AEPath.Text & "AfterFX.exe") Then
            Process.Start(AEPath.Text & "AfterFX.exe",
               "-s var selComp = app.project.selection;" &
               "if(selComp.length > 0 && selComp == ""[object CompItem]"")" &
               "{" &
                   "var renderObj = app.project.renderQueue.items.add(selComp[0]);" &
                   "renderObj.applyTemplate(""" & RenderSettingC.Text & """);" &
                   "renderObj.outputModule(1).applyTemplate(""" & OutputModuleC.Text & """);" &
               "}else{" &
                   "alert(""请在Project视图中选择合成组"", ""mutiAERenderScripts"");" &
               "}")
        Else
            MsgBox("路径错误")
        End If
    End Sub

    Private Sub AboutBtn_Click(sender As Object, e As EventArgs) Handles AboutBtn.Click
        AboutFrm.Show()
    End Sub

    Private Sub MultiOpenAEBtn_Click(sender As Object, e As EventArgs) Handles MultiOpenAEBtn.Click
        If File.Exists(AEPath.Text & "AfterFX.exe") Then
            Process.Start(AEPath.Text & "AfterFX.exe", "-m")
        Else
            MsgBox("路径错误")
        End If
    End Sub

    Private Sub AESRender_Click(sender As Object, e As EventArgs) Handles AESRender.Click
        If File.Exists(AEPath.Text & "AfterFX.exe") Then
            '不判断使用renderQueue.render会使AE进入非激活状态（无法交互）
            Process.Start(AEPath.Text & "AfterFX.exe",
                          "-s var qn=app.project.renderQueue.numItems;" &
                          "if(qn != 0 )" &
                             "{" &
                                "app.project.renderQueue.render();" &
                             "}else{" &
                                "alert(""渲染队列为空"");" &
                             "}"
                          )
        Else
            MsgBox("路径错误")
        End If
    End Sub

    Private Sub OpenAEPath_Click(sender As Object, e As EventArgs) Handles OpenAEPath.Click
        If Directory.Exists(AEPath.Text) Then
            Process.Start(AEPath.Text)
        Else
            MsgBox("路径错误")
        End If
    End Sub

    Private Sub RenderDoneShutDown_CheckedChanged(sender As Object, e As EventArgs) Handles RenderDoneShutDown.CheckedChanged

    End Sub

    Private Sub ClearRenderQ_Click(sender As Object, e As EventArgs) Handles ClearRenderQ.Click
        If Directory.Exists(AEPath.Text) Then
            Process.Start(AEPath.Text & "AfterFX.exe",
                          "-s var qn=app.project.renderQueue.numItems;" &
                          "if( qn != 0 ) " &
                             "for( var i=0; i<qn ;i++ )" &
                                "{ app.project.renderQueue.item(1).remove(); }")
        Else
            MsgBox("路径错误")
        End If
    End Sub

    Private Sub RendSetHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RendSetHelp.LinkClicked
        Process.Start("http://www.imxqy.com/info/soft/rotemp.html")
    End Sub

    Private Sub Mainfrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '保存配置文件
        Dim _config As New Configure
        _config.AePath = AEPath.Text
        _config.CurRenderSetting = RenderSettingC.Text
        For Each item In RenderSettingC.Items
            _config.RenderSetting.Add(item.ToString())
        Next
        If Not _config.RenderSetting.Contains(_config.CurRenderSetting) Then
            _config.RenderSetting.Add(_config.CurRenderSetting)
        End If
        _config.CurOutputModule = OutputModuleC.Text
        For Each item In OutputModuleC.Items
            _config.OutputModule.Add(item.ToString())
        Next
        If Not _config.OutputModule.Contains(_config.CurOutputModule) Then
            _config.OutputModule.Add(_config.CurOutputModule)
        End If
        _config.ThreadCount = ThreadNum.Text
        _config.WindowTop = TopWindowCheck.Checked
        _config.WindowTop = Me.TopMost
        _config.CompleteShutdown = RenderDoneShutDown.Checked
        _config.DisplayConsole = ShowRenderCK.Checked
        _config.OnlyConsole = OnlyShowOneCK.Checked
        _config.CompleteNotify = RenderDoneCk.Checked
        Config = _config
        Module1.Term()
    End Sub

    Private Sub ClearINI_Click(sender As Object, e As EventArgs) Handles ClearINI.Click
        Try
            If File.Exists(Application.StartupPath + "\" + CONFIG_FILENAME) Then
                File.Delete(Application.StartupPath + "\" + CONFIG_FILENAME)
            End If
            MsgBox("成功，请重启程序")
        Catch ex As Exception
            MsgBox("文件被占用")
        End Try
    End Sub

    Private Sub ReOpenEngine_Click(sender As Object, e As EventArgs) Handles ReOpenEngine.Click
        If File.Exists(AEPath.Text & "AfterFX.exe") Then
            Process.Start(AEPath.Text & "AfterFX.exe", "-re -m")
        Else
            MsgBox("路径错误")
        End If
    End Sub

    Private Sub TopWindowCheck_Click(sender As Object, e As EventArgs) Handles TopWindowCheck.Click
        Me.TopMost = TopWindowCheck.Checked
    End Sub
End Class
