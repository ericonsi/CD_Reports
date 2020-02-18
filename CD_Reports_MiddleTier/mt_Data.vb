
Public Class mt_Data
    Public Sub DELETE_AllCallListTableRecords()
        Try

            Dim ehq As New EH_DataUtilities.EH_QueryBuilder
            ehq.ASSIGN_FIRST_LINE("Delete from tblMasterClientCallList_HC")
            ehq.EXECUTE_NONQUERY()

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "The table is not empty.")

        End Try
    End Sub
    Public Sub CALL_PROCEDURE_iterateThroughComponents(ReportComponents As Boolean())
        Try

            Dim dt As DataTable
            Dim i As Integer = 0

            For Each rc In ReportComponents
                If rc Then
                    dt = CREATE_DataTableWithComponentInfo(i)
                    ADD_OR_UPDATE_DataTableRecordsToReportTable(dt)
                End If
                i = i + 1
            Next

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Sub
    Public Function CREATE_DataTableWithComponentInfo(ReportComponent As Integer) As DataTable
        Try

            Dim dt As DataTable
            Dim ehq As New EH_DataUtilities.EH_QueryBuilder

            ehq = CREATE_EHQ_ForSpecifiedComponent(ReportComponent)
            dt = ehq.ATTACH_TO_DATATABLE
            Return dt

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Function
    Public Sub ADD_OR_UPDATE_DataTableRecordsToReportTable(dt As DataTable)
        Try

            Dim bClientIsAlreadyInReport As Boolean

            For Each r As DataRow In dt.Rows
                bClientIsAlreadyInReport = DETERMINE_IfClientIsAlreadyInReport(r("ClientID"))
                If Not bClientIsAlreadyInReport Then
                    ADD_Client(r)
                Else
                    UPDATE_Client(r)
                End If
            Next

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Sub
    Public Function CREATE_EHQ_ForSpecifiedComponent(RecordComponent As Integer) As EH_DataUtilities.EH_QueryBuilder
        Try
            Dim ehq As New EH_DataUtilities.EH_QueryBuilder

            Select Case RecordComponent
                Case 0

                    ehq.ADD_TO_SELECT("ClientID")
                    ehq.ASSIGN_FROM_STATEMENT("tblClients")
                    ehq.ADD_TO_WHERE("ClientID>=30")

                Case 1

                    ehq.ADD_TO_SELECT("ClientID")
                    ehq.ASSIGN_FROM_STATEMENT("tblClients")
                    ehq.ADD_TO_WHERE("ClientID>=28")

                Case 2
                Case 3
            End Select

            Return ehq

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Function
    Public Function DETERMINE_IfClientIsAlreadyInReport(CID As Integer) As Boolean
        Try

            Dim ClientIsInReport As Boolean = False
            Dim ehq As New EH_DataUtilities.EH_QueryBuilder

            ehq.ADD_TO_SELECT("ClientID")
            ehq.ASSIGN_FROM_STATEMENT("tblMasterClientCallList_HC")
            ehq.ADD_TO_WHERE("ClientID = " & CID)

            If ehq.RECORD_COUNT > 0 Then
                ClientIsInReport = True
            End If

            Return ClientIsInReport

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Function
    Public Sub ADD_Client(r As DataRow)
        Try

            Dim ehq As New EH_DataUtilities.EH_QueryBuilder

            ehq.ASSIGN_FIRST_LINE("INSERT INTO tblMasterClientCallList_HC (ClientID) VALUES(" & r("ClientID") & ")")
            ehq.EXECUTE_NONQUERY()

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Sub
    Public Sub UPDATE_Client(r As DataRow)
        Try

            Dim ehq As New EH_DataUtilities.EH_QueryBuilder

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Sub
End Class
