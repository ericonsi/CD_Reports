Imports CD_Reports_MiddleTier.AppSetter
Public Class mt_Data
    Public Sub DELETE_AllCallListTableRecords()
        Try

            Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())
            ehq.ASSIGN_FIRST_LINE("Delete from tblMasterClientCallList_HC")
            ehq.EXECUTE_NONQUERY()

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "The table is not empty.")

        End Try
    End Sub
    Public Sub CALL_PROCEDURE_iterateThroughComponents(RComponents As List(Of IReportComponent))
        Try

            Dim dt As DataTable

            For Each rc In RComponents
                dt = CREATE_DataTableWithComponentInfo(rc)
                UPDATE_MasterClientlistWithReportComponentInfo(dt, rc)
            Next

            UPDATE_MasterClientListWithClubHCMembershipStatus()


        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Sub
    Public Function CREATE_DataTableWithComponentInfo(RComponent As IReportComponent) As DataTable
        Try

            Dim dt As DataTable
            Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

            ehq = RComponent.GetSelectQuery()
            dt = ehq.ATTACH_TO_DATATABLE
            Return dt

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Function
    Public Sub UPDATE_MasterClientlistWithReportComponentInfo(dt As DataTable, rc As IReportComponent)
        Try

            Dim bClientIsAlreadyInReport As Boolean

            For Each r As DataRow In dt.Rows
                bClientIsAlreadyInReport = DETERMINE_IfClientIsAlreadyInReport(r("ClientID"))
                If Not bClientIsAlreadyInReport Then
                    ADD_Client(r)
                End If

                'This is messy and prone to errors.  The original ReportComponent classes only needed clientID for the update query - this
                ' occurred in order to hande the reminder class which needs more than the clientID.  Then I got too lazy to implement a design pattern.

                If rc.GetDescription = "Reminder List Items" Then

                    Dim rm As New Reminder
                    rm.ReminderDetail = r("Details")
                    rm.ReminderItem = r("Item")
                    rm.ClientID = r("ClientID")

                    Dim rc_rm As New ReportComponent_RemindersList

                    rc_rm.GetUpdateQuery(rm).EXECUTE_NONQUERY()

                Else
                    rc.GetUpdateQuery(r("clientID")).EXECUTE_NONQUERY()
                End If
            Next

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Sub
    Public Function DETERMINE_IfClientIsAlreadyInReport(CID As Integer) As Boolean
        Try

            Dim ClientIsInReport As Boolean = False
            Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

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

            Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

            ehq.ASSIGN_FIRST_LINE("INSERT INTO tblMasterClientCallList_HC (ClientID) VALUES(" & r("ClientID") & ")")
            ehq.EXECUTE_NONQUERY()

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Sub
    Public Sub UPDATE_MasterClientListWithClubHCMembershipStatus()

        Try

            Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())
            ehq.ASSIGN_FIRST_LINE("")


        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Sub
End Class
