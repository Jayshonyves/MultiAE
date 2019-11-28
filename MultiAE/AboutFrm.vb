Public Class AboutFrm

    Private Sub AboutFrm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawRectangle(New Pen(Color.FromArgb(0, 122, 204)), 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://www.imxqy.com/info/soft/aebatchrender.html")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.imxqy.com/")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("http://www.imxqy.com/info/soft/multiaerender.html")
    End Sub
End Class