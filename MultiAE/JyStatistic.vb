Imports System.Threading
Imports System.Net
Imports System.IO
Imports System.Text

Public Class JyStatistic

    Public Event PostDone(s As String)

    Public Sub Post(url As String, programName As String)

        Dim getparm As New PostData(url, programName)
        Dim pth As New Thread(New ParameterizedThreadStart(AddressOf getthread))
        pth.IsBackground = True
        pth.Start(getparm)

    End Sub

    Private Sub getthread(program As Object)
        Try
            Dim pn As PostData = program
            Dim request As HttpWebRequest = WebRequest.Create(pn.url & "?" & pn.data)
            request.Method = "GET"
            request.UserAgent = "Jasic/2.0 (JasicOS 3; rv:2.0) Gecko/20181001 JasicBrowser/2.0.1"
            Dim sr As StreamReader = New StreamReader(request.GetResponse().GetResponseStream)
            RaiseEvent PostDone(sr.ReadToEnd)
        Catch ex As Exception

        End Try
    End Sub

    Public Class PostData
        Public url As String
        Public data As String
        Sub New(u As String, d As String)
            url = u
            data = d
        End Sub
    End Class
End Class
