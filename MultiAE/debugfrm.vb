Public Class debugfrm
    Private Sub debugfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub debugOut(debugstr As String)
        If TextBox1.TextLength > 30000 Then TextBox1.Text = ""
        TextBox1.Text += Now & ">" & debugstr & vbCrLf
        TextBox1.SelectionStart = TextBox1.TextLength
        TextBox1.ScrollToCaret()
    End Sub

End Class