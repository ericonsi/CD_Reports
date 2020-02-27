Public Class AppSetter
    Public Shared Function GetHostSqlServer()

        Dim computer As String = System.Configuration.ConfigurationManager.AppSettings("computer")
        Return "connection_string_" + computer

    End Function
End Class
