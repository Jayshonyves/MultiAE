Module Module1
    Public useCount As String = ""
    Public Const Ver As String = "1.5"
    Public Const verDate As String = "2019-11-27"


    Private Declare Function GetPrivateProfileInt Lib "kernel32" Alias "GetPrivateProfileIntA" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal nDefault As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Public Function GetIntFromINI(ByVal sectionName As String, ByVal keyName As String, ByVal defaultValue As Integer, ByVal iniPath As String) As Integer
        GetIntFromINI = GetPrivateProfileInt(sectionName, keyName, defaultValue, iniPath)
    End Function
    Public Function GetStrFromINI(ByVal sectionName As String, ByVal keyName As String, ByVal defaultValue As String, ByVal iniPath As String) As String
        Dim buffer As String
        Dim rc As Integer
        buffer = Space(256)
        rc = GetPrivateProfileString(sectionName, keyName, defaultValue, buffer, buffer.Length, iniPath)
        GetStrFromINI = Left(buffer, InStr(buffer, vbNullChar) - 1)
        End Function
    Public Function WriteStrINI(ByVal sectionName As String, ByVal keyName As String, ByVal setValue As String, ByVal iniPath As String) As Integer
        Dim rc As Integer
        rc = WritePrivateProfileString(sectionName, keyName, setValue, iniPath)
        If rc Then
            rc = 1
        End If
        WriteStrINI = rc
    End Function
End Module
