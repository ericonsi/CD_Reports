Imports EH_DataUtilities.EH_LookUp
Imports EH_DataUtilities.EH_QueryBuilder
Public Class mt_LookUps
    Public Shared Function LOOKUP_TraceFileLocation() As String
        Try

            Return Standard_Lookup("Setting_Type", "Setting", "tblSettings", "TraceFileLocation")

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.BasicHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "There is a problem identifying the trace file.")
        End Try

    End Function

    Public Shared Function LOOKUP_System_User() As String

        Try

            Return EH_DataUtilities.GeneralDataFunctions.RETRIEVE_System_User

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.BasicHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "There is a problem identifying the system user.")
        End Try

    End Function

    Public Shared Function LOOKUP_RunConditionalTrace() As String
        Try

            Return Standard_Lookup("Setting_Type", "Setting", "tblSettings", "RunConditionalTrace")

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.TraceOnlyHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "", "Error looking up RunConditionalTrace so the value is set to True.")
            Return True
        End Try

    End Function
    Public Shared Function LOOKUP_ReportServerUrl() As String

        Try

            Return Standard_Lookup("Setting_Type", "Setting", "tblSettings", "Report_Server_URL")

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.BasicHandler
        HandleStandardException.HANDLE_EXCEPTION(ex, True, "There is a problem with the Report Server.  You might try a different time.")
        End Try

    End Function
    Public Shared Function LOOKUP_ToolbarPassword() As String

        Try

            Return Standard_Lookup("Setting_Type", "Setting", "tblSettings", "Toolbar_Password")

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "There is an error retreiving the toolbar password.")
        End Try
    End Function
    Public Shared Function LOOKUP_HelpFileLocation() As String

        Try

            Return Standard_Lookup("Setting_Type", "Setting", "tblSettings", "HelpFileLocation")

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "There is an error retreiving the Help File location.")
        End Try
    End Function
    Public Shared Function LOOKUP_ProgramIDFromIndicatorID(indID As Integer) As Integer
        Try

            Return Standard_Lookup("IndicatorID", "ProgramID", "tblIndicators", indID)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.BasicHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "There is a problem.")
        End Try

    End Function
    Public Shared Function LOOKUP_ProgramNameFromProgramID(proID As Integer) As String
        Try

            Return Standard_Lookup("ProgramID", "Program", "tblPrograms", proID)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.BasicHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "There is a problem.")
        End Try

    End Function
End Class
