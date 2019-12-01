Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization


Module Module1
    Public useCount As String = ""
    Public Const Ver As String = "1.5"
    Public Const verDate As String = "2019-11-27"
    Public Const CONFIG_FILENAME As String = "multiae.config.xml"

    Public Config As Configure
    Public Function Init() As Boolean
        Config = New Configure()
        '读取配置文件
        Dim configIsExist As Boolean = File.Exists(CONFIG_FILENAME)
        If configIsExist Then
            Dim xmls As New XmlSerializer(GetType(Configure))
            Dim fs As FileStream = File.Open(CONFIG_FILENAME, FileMode.Open, FileAccess.Read, FileShare.Read)
            Config = xmls.Deserialize(fs)
            fs.Close()
        End If
        Return configIsExist
    End Function
    Public Sub Term()
        '保存配置文件
        Dim xmls As New XmlSerializer(GetType(Configure))
        Dim fs As FileStream = File.Open(CONFIG_FILENAME, FileMode.Create, FileAccess.Write, FileShare.Write)
        xmls.Serialize(fs, Config)
        fs.Close()
    End Sub

End Module
