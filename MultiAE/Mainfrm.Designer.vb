<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainfrm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainfrm))
        Me.SchAEBtn = New System.Windows.Forms.Button()
        Me.AEPath = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckAEPath = New System.Windows.Forms.Button()
        Me.RenderModeL = New System.Windows.Forms.Label()
        Me.WatchFolder = New System.Windows.Forms.TextBox()
        Me.FindWatchFolder = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ThreadNum = New System.Windows.Forms.ComboBox()
        Me.StartRenderBtn = New System.Windows.Forms.Button()
        Me.StopALLBtn = New System.Windows.Forms.Button()
        Me.ProFrm = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UseInc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RenderModeL2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LB = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RenderDoneCk = New System.Windows.Forms.CheckBox()
        Me.ShowRenderCK = New System.Windows.Forms.CheckBox()
        Me.RenderStatL = New System.Windows.Forms.Label()
        Me.VerShowL = New System.Windows.Forms.Label()
        Me.OnlyShowOneCK = New System.Windows.Forms.CheckBox()
        Me.RenderDoneShutDown = New System.Windows.Forms.CheckBox()
        Me.CancelShutdown = New System.Windows.Forms.Button()
        Me.RunScriptsBtn = New System.Windows.Forms.Button()
        Me.OpenAEBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AERenderEngineBtn = New System.Windows.Forms.Button()
        Me.CMDBtn = New System.Windows.Forms.Button()
        Me.TestConnBtn = New System.Windows.Forms.Button()
        Me.ForceStopALL = New System.Windows.Forms.Button()
        Me.AboutBtn = New System.Windows.Forms.Button()
        Me.ClearRenderQ = New System.Windows.Forms.Button()
        Me.AESRender = New System.Windows.Forms.Button()
        Me.MultiOpenAEBtn = New System.Windows.Forms.Button()
        Me.OpenAEPath = New System.Windows.Forms.Button()
        Me.ReOpenEngine = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RenderSettingC = New System.Windows.Forms.ComboBox()
        Me.OutputModuleC = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RendSetHelp = New System.Windows.Forms.LinkLabel()
        Me.ClearINI = New System.Windows.Forms.Button()
        Me.TopWindowBtn = New System.Windows.Forms.Button()
        Me.LB.SuspendLayout()
        Me.SuspendLayout()
        '
        'SchAEBtn
        '
        Me.SchAEBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.SchAEBtn.FlatAppearance.BorderSize = 0
        Me.SchAEBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SchAEBtn.Location = New System.Drawing.Point(396, 90)
        Me.SchAEBtn.Name = "SchAEBtn"
        Me.SchAEBtn.Size = New System.Drawing.Size(87, 29)
        Me.SchAEBtn.TabIndex = 0
        Me.SchAEBtn.Text = "自动查找"
        Me.SchAEBtn.UseVisualStyleBackColor = False
        '
        'AEPath
        '
        Me.AEPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.AEPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AEPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AEPath.FormattingEnabled = True
        Me.AEPath.Location = New System.Drawing.Point(32, 59)
        Me.AEPath.Name = "AEPath"
        Me.AEPath.Size = New System.Drawing.Size(546, 25)
        Me.AEPath.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AE路径 "
        '
        'CheckAEPath
        '
        Me.CheckAEPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.CheckAEPath.FlatAppearance.BorderSize = 0
        Me.CheckAEPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckAEPath.Location = New System.Drawing.Point(489, 90)
        Me.CheckAEPath.Name = "CheckAEPath"
        Me.CheckAEPath.Size = New System.Drawing.Size(87, 29)
        Me.CheckAEPath.TabIndex = 3
        Me.CheckAEPath.Text = "手动选择"
        Me.CheckAEPath.UseVisualStyleBackColor = False
        '
        'RenderModeL
        '
        Me.RenderModeL.AutoSize = True
        Me.RenderModeL.Location = New System.Drawing.Point(29, 315)
        Me.RenderModeL.Name = "RenderModeL"
        Me.RenderModeL.Size = New System.Drawing.Size(92, 17)
        Me.RenderModeL.TabIndex = 4
        Me.RenderModeL.Text = "渲染单工程文件"
        '
        'WatchFolder
        '
        Me.WatchFolder.AllowDrop = True
        Me.WatchFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.WatchFolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.WatchFolder.Location = New System.Drawing.Point(32, 344)
        Me.WatchFolder.Name = "WatchFolder"
        Me.WatchFolder.Size = New System.Drawing.Size(546, 23)
        Me.WatchFolder.TabIndex = 5
        '
        'FindWatchFolder
        '
        Me.FindWatchFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.FindWatchFolder.FlatAppearance.BorderSize = 0
        Me.FindWatchFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindWatchFolder.Location = New System.Drawing.Point(493, 373)
        Me.FindWatchFolder.Name = "FindWatchFolder"
        Me.FindWatchFolder.Size = New System.Drawing.Size(87, 29)
        Me.FindWatchFolder.TabIndex = 6
        Me.FindWatchFolder.Text = "手动选择"
        Me.FindWatchFolder.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(234, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "线程数"
        '
        'ThreadNum
        '
        Me.ThreadNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ThreadNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ThreadNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ThreadNum.FormattingEnabled = True
        Me.ThreadNum.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ThreadNum.Location = New System.Drawing.Point(284, 271)
        Me.ThreadNum.Name = "ThreadNum"
        Me.ThreadNum.Size = New System.Drawing.Size(45, 25)
        Me.ThreadNum.TabIndex = 11
        Me.ThreadNum.Text = "1"
        '
        'StartRenderBtn
        '
        Me.StartRenderBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.StartRenderBtn.FlatAppearance.BorderSize = 0
        Me.StartRenderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartRenderBtn.ForeColor = System.Drawing.Color.Aqua
        Me.StartRenderBtn.Location = New System.Drawing.Point(466, 480)
        Me.StartRenderBtn.Name = "StartRenderBtn"
        Me.StartRenderBtn.Size = New System.Drawing.Size(109, 29)
        Me.StartRenderBtn.TabIndex = 12
        Me.StartRenderBtn.Text = "开始渲染作业"
        Me.StartRenderBtn.UseVisualStyleBackColor = False
        '
        'StopALLBtn
        '
        Me.StopALLBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.StopALLBtn.Enabled = False
        Me.StopALLBtn.FlatAppearance.BorderSize = 0
        Me.StopALLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopALLBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StopALLBtn.Location = New System.Drawing.Point(246, 480)
        Me.StopALLBtn.Name = "StopALLBtn"
        Me.StopALLBtn.Size = New System.Drawing.Size(100, 29)
        Me.StopALLBtn.TabIndex = 13
        Me.StopALLBtn.Text = "全部停止"
        Me.StopALLBtn.UseVisualStyleBackColor = False
        '
        'ProFrm
        '
        Me.ProFrm.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ProFrm.Enabled = False
        Me.ProFrm.FlatAppearance.BorderSize = 0
        Me.ProFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProFrm.Location = New System.Drawing.Point(138, 480)
        Me.ProFrm.Name = "ProFrm"
        Me.ProFrm.Size = New System.Drawing.Size(100, 29)
        Me.ProFrm.TabIndex = 14
        Me.ProFrm.Text = "进度监视窗口"
        Me.ProFrm.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LinkLabel1.LinkArea = New System.Windows.Forms.LinkArea(23, 48)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(10, 569)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(278, 21)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "By Jayshonyves  BLOG:  http//www.imxqy.com"
        Me.LinkLabel1.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 552)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = ">>了解多台计算机一起渲染？>> (鸽了)"
        Me.Label5.Visible = False
        '
        'UseInc
        '
        Me.UseInc.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.UseInc.FlatAppearance.BorderSize = 0
        Me.UseInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UseInc.Location = New System.Drawing.Point(138, 515)
        Me.UseInc.Name = "UseInc"
        Me.UseInc.Size = New System.Drawing.Size(100, 29)
        Me.UseInc.TabIndex = 17
        Me.UseInc.Text = "使用教程"
        Me.UseInc.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(97, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "选择SupportFiles文件夹"
        '
        'RenderModeL2
        '
        Me.RenderModeL2.AutoSize = True
        Me.RenderModeL2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RenderModeL2.ForeColor = System.Drawing.Color.Gray
        Me.RenderModeL2.Location = New System.Drawing.Point(135, 315)
        Me.RenderModeL2.Name = "RenderModeL2"
        Me.RenderModeL2.Size = New System.Drawing.Size(240, 17)
        Me.RenderModeL2.TabIndex = 21
        Me.RenderModeL2.Text = "在渲染监视目录工程模式下启用    选择打包"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"直接渲染单工程", "渲染监视目录工程"})
        Me.ComboBox1.Location = New System.Drawing.Point(90, 271)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(125, 25)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.Text = "直接渲染单工程"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "渲染方式"
        '
        'LB
        '
        Me.LB.AllowDrop = True
        Me.LB.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.LB.Controls.Add(Me.Label2)
        Me.LB.Location = New System.Drawing.Point(34, 373)
        Me.LB.Name = "LB"
        Me.LB.Size = New System.Drawing.Size(451, 72)
        Me.LB.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(84, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "选择文件(夹)路径或拖动文件(夹)至此区域"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'RenderDoneCk
        '
        Me.RenderDoneCk.AutoSize = True
        Me.RenderDoneCk.Checked = True
        Me.RenderDoneCk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RenderDoneCk.Location = New System.Drawing.Point(482, 453)
        Me.RenderDoneCk.Name = "RenderDoneCk"
        Me.RenderDoneCk.Size = New System.Drawing.Size(99, 21)
        Me.RenderDoneCk.TabIndex = 26
        Me.RenderDoneCk.Text = "渲染完成通知"
        Me.RenderDoneCk.UseVisualStyleBackColor = True
        '
        'ShowRenderCK
        '
        Me.ShowRenderCK.AutoSize = True
        Me.ShowRenderCK.Checked = True
        Me.ShowRenderCK.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowRenderCK.Location = New System.Drawing.Point(235, 453)
        Me.ShowRenderCK.Name = "ShowRenderCK"
        Me.ShowRenderCK.Size = New System.Drawing.Size(111, 21)
        Me.ShowRenderCK.TabIndex = 28
        Me.ShowRenderCK.Text = "显示渲染控制台"
        Me.ShowRenderCK.UseVisualStyleBackColor = True
        '
        'RenderStatL
        '
        Me.RenderStatL.Location = New System.Drawing.Point(412, 552)
        Me.RenderStatL.Name = "RenderStatL"
        Me.RenderStatL.Size = New System.Drawing.Size(166, 17)
        Me.RenderStatL.TabIndex = 29
        Me.RenderStatL.Text = "就绪."
        Me.RenderStatL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VerShowL
        '
        Me.VerShowL.AutoSize = True
        Me.VerShowL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.VerShowL.Location = New System.Drawing.Point(464, 570)
        Me.VerShowL.Name = "VerShowL"
        Me.VerShowL.Size = New System.Drawing.Size(114, 17)
        Me.VerShowL.TabIndex = 30
        Me.VerShowL.Text = "MultiAERenderVer"
        '
        'OnlyShowOneCK
        '
        Me.OnlyShowOneCK.AutoSize = True
        Me.OnlyShowOneCK.Checked = True
        Me.OnlyShowOneCK.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OnlyShowOneCK.Location = New System.Drawing.Point(352, 453)
        Me.OnlyShowOneCK.Name = "OnlyShowOneCK"
        Me.OnlyShowOneCK.Size = New System.Drawing.Size(123, 21)
        Me.OnlyShowOneCK.TabIndex = 31
        Me.OnlyShowOneCK.Text = "仅显示一个控制台"
        Me.OnlyShowOneCK.UseVisualStyleBackColor = True
        '
        'RenderDoneShutDown
        '
        Me.RenderDoneShutDown.AutoSize = True
        Me.RenderDoneShutDown.ForeColor = System.Drawing.Color.Silver
        Me.RenderDoneShutDown.Location = New System.Drawing.Point(118, 453)
        Me.RenderDoneShutDown.Name = "RenderDoneShutDown"
        Me.RenderDoneShutDown.Size = New System.Drawing.Size(111, 21)
        Me.RenderDoneShutDown.TabIndex = 32
        Me.RenderDoneShutDown.Text = "完成后自动关机"
        Me.RenderDoneShutDown.UseVisualStyleBackColor = True
        '
        'CancelShutdown
        '
        Me.CancelShutdown.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.CancelShutdown.Enabled = False
        Me.CancelShutdown.FlatAppearance.BorderSize = 0
        Me.CancelShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelShutdown.Location = New System.Drawing.Point(32, 480)
        Me.CancelShutdown.Name = "CancelShutdown"
        Me.CancelShutdown.Size = New System.Drawing.Size(100, 29)
        Me.CancelShutdown.TabIndex = 33
        Me.CancelShutdown.Text = "取消关机"
        Me.CancelShutdown.UseVisualStyleBackColor = False
        '
        'RunScriptsBtn
        '
        Me.RunScriptsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.RunScriptsBtn.FlatAppearance.BorderSize = 0
        Me.RunScriptsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RunScriptsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RunScriptsBtn.Location = New System.Drawing.Point(469, 197)
        Me.RunScriptsBtn.Name = "RunScriptsBtn"
        Me.RunScriptsBtn.Size = New System.Drawing.Size(109, 29)
        Me.RunScriptsBtn.TabIndex = 34
        Me.RunScriptsBtn.Text = "添加至队列"
        Me.RunScriptsBtn.UseVisualStyleBackColor = False
        '
        'OpenAEBtn
        '
        Me.OpenAEBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.OpenAEBtn.FlatAppearance.BorderSize = 0
        Me.OpenAEBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenAEBtn.Location = New System.Drawing.Point(34, 197)
        Me.OpenAEBtn.Name = "OpenAEBtn"
        Me.OpenAEBtn.Size = New System.Drawing.Size(100, 29)
        Me.OpenAEBtn.TabIndex = 36
        Me.OpenAEBtn.Text = "打开AE"
        Me.OpenAEBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(33, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "如果使用监视渲染请在打包时设置好最大线程数"
        '
        'AERenderEngineBtn
        '
        Me.AERenderEngineBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.AERenderEngineBtn.FlatAppearance.BorderSize = 0
        Me.AERenderEngineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AERenderEngineBtn.Location = New System.Drawing.Point(34, 232)
        Me.AERenderEngineBtn.Name = "AERenderEngineBtn"
        Me.AERenderEngineBtn.Size = New System.Drawing.Size(100, 29)
        Me.AERenderEngineBtn.TabIndex = 38
        Me.AERenderEngineBtn.Text = "AE渲染引擎"
        Me.AERenderEngineBtn.UseVisualStyleBackColor = False
        '
        'CMDBtn
        '
        Me.CMDBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.CMDBtn.FlatAppearance.BorderSize = 0
        Me.CMDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDBtn.Location = New System.Drawing.Point(246, 197)
        Me.CMDBtn.Name = "CMDBtn"
        Me.CMDBtn.Size = New System.Drawing.Size(100, 29)
        Me.CMDBtn.TabIndex = 39
        Me.CMDBtn.Text = "命令提示符"
        Me.CMDBtn.UseVisualStyleBackColor = False
        '
        'TestConnBtn
        '
        Me.TestConnBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.TestConnBtn.FlatAppearance.BorderSize = 0
        Me.TestConnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TestConnBtn.Location = New System.Drawing.Point(354, 197)
        Me.TestConnBtn.Name = "TestConnBtn"
        Me.TestConnBtn.Size = New System.Drawing.Size(108, 29)
        Me.TestConnBtn.TabIndex = 40
        Me.TestConnBtn.Text = "测试连接"
        Me.TestConnBtn.UseVisualStyleBackColor = False
        '
        'ForceStopALL
        '
        Me.ForceStopALL.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ForceStopALL.Enabled = False
        Me.ForceStopALL.FlatAppearance.BorderSize = 0
        Me.ForceStopALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForceStopALL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ForceStopALL.Location = New System.Drawing.Point(352, 480)
        Me.ForceStopALL.Name = "ForceStopALL"
        Me.ForceStopALL.Size = New System.Drawing.Size(108, 29)
        Me.ForceStopALL.TabIndex = 41
        Me.ForceStopALL.Text = "全部结束(强制)"
        Me.ForceStopALL.UseVisualStyleBackColor = False
        '
        'AboutBtn
        '
        Me.AboutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.AboutBtn.FlatAppearance.BorderSize = 0
        Me.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutBtn.Location = New System.Drawing.Point(31, 515)
        Me.AboutBtn.Name = "AboutBtn"
        Me.AboutBtn.Size = New System.Drawing.Size(100, 29)
        Me.AboutBtn.TabIndex = 42
        Me.AboutBtn.Text = "关于软件"
        Me.AboutBtn.UseVisualStyleBackColor = False
        '
        'ClearRenderQ
        '
        Me.ClearRenderQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClearRenderQ.FlatAppearance.BorderSize = 0
        Me.ClearRenderQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearRenderQ.Location = New System.Drawing.Point(468, 232)
        Me.ClearRenderQ.Name = "ClearRenderQ"
        Me.ClearRenderQ.Size = New System.Drawing.Size(109, 29)
        Me.ClearRenderQ.TabIndex = 43
        Me.ClearRenderQ.Text = "清空队列"
        Me.ClearRenderQ.UseVisualStyleBackColor = False
        '
        'AESRender
        '
        Me.AESRender.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.AESRender.FlatAppearance.BorderSize = 0
        Me.AESRender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AESRender.Location = New System.Drawing.Point(353, 232)
        Me.AESRender.Name = "AESRender"
        Me.AESRender.Size = New System.Drawing.Size(109, 29)
        Me.AESRender.TabIndex = 44
        Me.AESRender.Text = "在AE内开始渲染"
        Me.AESRender.UseVisualStyleBackColor = False
        '
        'MultiOpenAEBtn
        '
        Me.MultiOpenAEBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.MultiOpenAEBtn.FlatAppearance.BorderSize = 0
        Me.MultiOpenAEBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MultiOpenAEBtn.Location = New System.Drawing.Point(140, 197)
        Me.MultiOpenAEBtn.Name = "MultiOpenAEBtn"
        Me.MultiOpenAEBtn.Size = New System.Drawing.Size(100, 29)
        Me.MultiOpenAEBtn.TabIndex = 45
        Me.MultiOpenAEBtn.Text = "再开一个AE"
        Me.MultiOpenAEBtn.UseVisualStyleBackColor = False
        '
        'OpenAEPath
        '
        Me.OpenAEPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.OpenAEPath.FlatAppearance.BorderSize = 0
        Me.OpenAEPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenAEPath.Location = New System.Drawing.Point(246, 232)
        Me.OpenAEPath.Name = "OpenAEPath"
        Me.OpenAEPath.Size = New System.Drawing.Size(100, 29)
        Me.OpenAEPath.TabIndex = 46
        Me.OpenAEPath.Text = "打开AE位置"
        Me.OpenAEPath.UseVisualStyleBackColor = False
        '
        'ReOpenEngine
        '
        Me.ReOpenEngine.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ReOpenEngine.FlatAppearance.BorderSize = 0
        Me.ReOpenEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReOpenEngine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ReOpenEngine.Location = New System.Drawing.Point(140, 232)
        Me.ReOpenEngine.Name = "ReOpenEngine"
        Me.ReOpenEngine.Size = New System.Drawing.Size(100, 29)
        Me.ReOpenEngine.TabIndex = 47
        Me.ReOpenEngine.Text = "再开一个引擎"
        Me.ReOpenEngine.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(410, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 34)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "如果使用监视渲染而且使用" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "网络地址时一定要进行打包"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 17)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "选择或输入渲染设置模板"
        '
        'RenderSettingC
        '
        Me.RenderSettingC.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.RenderSettingC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RenderSettingC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RenderSettingC.FormattingEnabled = True
        Me.RenderSettingC.Items.AddRange(New Object() {"Multi-Machine Settings"})
        Me.RenderSettingC.Location = New System.Drawing.Point(181, 128)
        Me.RenderSettingC.Name = "RenderSettingC"
        Me.RenderSettingC.Size = New System.Drawing.Size(237, 25)
        Me.RenderSettingC.TabIndex = 49
        Me.RenderSettingC.Text = "Multi-Machine Settings"
        '
        'OutputModuleC
        '
        Me.OutputModuleC.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.OutputModuleC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OutputModuleC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.OutputModuleC.FormattingEnabled = True
        Me.OutputModuleC.Items.AddRange(New Object() {"Multi-Machine Sequence", "Photoshop", "TIFF Sequence with Alpha"})
        Me.OutputModuleC.Location = New System.Drawing.Point(181, 159)
        Me.OutputModuleC.Name = "OutputModuleC"
        Me.OutputModuleC.Size = New System.Drawing.Size(237, 25)
        Me.OutputModuleC.TabIndex = 51
        Me.OutputModuleC.Text = "TIFF Sequence with Alpha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 17)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "选择或输入输出模块模板"
        '
        'RendSetHelp
        '
        Me.RendSetHelp.AutoSize = True
        Me.RendSetHelp.LinkColor = System.Drawing.Color.DodgerBlue
        Me.RendSetHelp.Location = New System.Drawing.Point(435, 131)
        Me.RendSetHelp.Name = "RendSetHelp"
        Me.RendSetHelp.Size = New System.Drawing.Size(50, 17)
        Me.RendSetHelp.TabIndex = 52
        Me.RendSetHelp.TabStop = True
        Me.RendSetHelp.Text = "帮助>>"
        '
        'ClearINI
        '
        Me.ClearINI.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClearINI.FlatAppearance.BorderSize = 0
        Me.ClearINI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearINI.Location = New System.Drawing.Point(246, 515)
        Me.ClearINI.Name = "ClearINI"
        Me.ClearINI.Size = New System.Drawing.Size(100, 29)
        Me.ClearINI.TabIndex = 53
        Me.ClearINI.Text = "恢复设置"
        Me.ClearINI.UseVisualStyleBackColor = False
        '
        'TopWindowBtn
        '
        Me.TopWindowBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.TopWindowBtn.FlatAppearance.BorderSize = 0
        Me.TopWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopWindowBtn.Location = New System.Drawing.Point(352, 515)
        Me.TopWindowBtn.Name = "TopWindowBtn"
        Me.TopWindowBtn.Size = New System.Drawing.Size(108, 29)
        Me.TopWindowBtn.TabIndex = 54
        Me.TopWindowBtn.Text = "置顶窗口"
        Me.TopWindowBtn.UseVisualStyleBackColor = False
        '
        'Mainfrm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(610, 594)
        Me.Controls.Add(Me.TopWindowBtn)
        Me.Controls.Add(Me.ClearINI)
        Me.Controls.Add(Me.RendSetHelp)
        Me.Controls.Add(Me.OutputModuleC)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RenderSettingC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ReOpenEngine)
        Me.Controls.Add(Me.OpenAEPath)
        Me.Controls.Add(Me.MultiOpenAEBtn)
        Me.Controls.Add(Me.AESRender)
        Me.Controls.Add(Me.ClearRenderQ)
        Me.Controls.Add(Me.AboutBtn)
        Me.Controls.Add(Me.ForceStopALL)
        Me.Controls.Add(Me.TestConnBtn)
        Me.Controls.Add(Me.CMDBtn)
        Me.Controls.Add(Me.AERenderEngineBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OpenAEBtn)
        Me.Controls.Add(Me.RunScriptsBtn)
        Me.Controls.Add(Me.CancelShutdown)
        Me.Controls.Add(Me.RenderDoneShutDown)
        Me.Controls.Add(Me.OnlyShowOneCK)
        Me.Controls.Add(Me.VerShowL)
        Me.Controls.Add(Me.RenderStatL)
        Me.Controls.Add(Me.ShowRenderCK)
        Me.Controls.Add(Me.RenderDoneCk)
        Me.Controls.Add(Me.LB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RenderModeL2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.UseInc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ProFrm)
        Me.Controls.Add(Me.StopALLBtn)
        Me.Controls.Add(Me.StartRenderBtn)
        Me.Controls.Add(Me.ThreadNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FindWatchFolder)
        Me.Controls.Add(Me.WatchFolder)
        Me.Controls.Add(Me.RenderModeL)
        Me.Controls.Add(Me.CheckAEPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AEPath)
        Me.Controls.Add(Me.SchAEBtn)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Mainfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AE多开多线程渲染工具 MultiAERender"
        Me.LB.ResumeLayout(False)
        Me.LB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SchAEBtn As Button
    Friend WithEvents AEPath As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckAEPath As Button
    Friend WithEvents RenderModeL As Label
    Friend WithEvents WatchFolder As TextBox
    Friend WithEvents FindWatchFolder As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ThreadNum As ComboBox
    Friend WithEvents StartRenderBtn As Button
    Friend WithEvents StopALLBtn As Button
    Friend WithEvents ProFrm As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents UseInc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents RenderModeL2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LB As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RenderDoneCk As CheckBox
    Friend WithEvents ShowRenderCK As CheckBox
    Friend WithEvents RenderStatL As Label
    Friend WithEvents VerShowL As Label
    Friend WithEvents OnlyShowOneCK As CheckBox
    Friend WithEvents RenderDoneShutDown As CheckBox
    Friend WithEvents CancelShutdown As Button
    Friend WithEvents RunScriptsBtn As Button
    Friend WithEvents OpenAEBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents AERenderEngineBtn As Button
    Friend WithEvents CMDBtn As Button
    Friend WithEvents TestConnBtn As Button
    Friend WithEvents ForceStopALL As Button
    Friend WithEvents AboutBtn As Button
    Friend WithEvents ClearRenderQ As Button
    Friend WithEvents AESRender As Button
    Friend WithEvents MultiOpenAEBtn As Button
    Friend WithEvents OpenAEPath As Button
    Friend WithEvents ReOpenEngine As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RenderSettingC As ComboBox
    Friend WithEvents OutputModuleC As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RendSetHelp As LinkLabel
    Friend WithEvents ClearINI As Button
    Friend WithEvents TopWindowBtn As Button
End Class
