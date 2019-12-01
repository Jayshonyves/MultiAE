Public Class Configure
    Public AePath As String

    Public RenderSetting As List(Of String)
    Public CurRenderSetting As String
    Public OutputModule As List(Of String)
    Public CurOutputModule As String
    Public RenderMode As Integer
    Public ThreadCount As Integer

    Public WindowTop As Boolean
    Public CompleteShutdown As Boolean
    Public DisplayConsole As Boolean
    Public OnlyConsole As Boolean
    Public CompleteNotify As Boolean

    Public Sub New()
        RenderSetting = New List(Of String)
        OutputModule = New List(Of String)
    End Sub
End Class
