Imports System.IO

Public Class WatchFrm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = "监视" & " - " & Now

        Dim dz As String = Mainfrm.ProjectFolder & "\watch_folder.htm"
        If File.Exists(dz) Then
            WebBrowser1.Url = New Uri(dz)
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class