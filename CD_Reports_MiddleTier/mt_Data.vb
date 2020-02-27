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
                UPDATE_DataTableRecordsWithReportComponentInfo(dt, rc)

            Next

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
    Public Sub UPDATE_DataTableRecordsWithReportComponentInfo(dt As DataTable, rc As IReportComponent)
        Try

            Dim bClientIsAlreadyInReport As Boolean

            For Each r As DataRow In dt.Rows
                bClientIsAlreadyInReport = DETERMINE_IfClientIsAlreadyInReport(r("ClientID"))
                If Not bClientIsAlreadyInReport Then
                    ADD_Client(r)
                End If

                rc.GetUpdateQuery(r("clientID")).EXECUTE_NONQUERY()

            Next

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Sub
    Public Function CREATE_EHQ_ForSpecifiedComponent(RecordComponent As Integer) As EH_DataUtilities.EH_QueryBuilder
        Try
            Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

            Select Case RecordComponent
                Case 0

                    ehq.ADD_TO_SELECT(" tblServices.ClientID")
                    ehq.ASSIGN_FROM_STATEMENT("tblServices INNER Join tblVitalSigns On tblServices.ServiceID = tblVitalSigns.ServiceID")
                    ehq.ADD_TO_WHERE("(((tblServices.Program) ='HealthConnect') AND ((tblVitalSigns.Type)='blood pressure' Or (tblVitalSigns.Type)='A1C') AND ((tblVitalSigns.Stage)='baseline') AND ((DateDiff(Month,[date of service],GetDate()))>=2))")
                    ehq.ADD_TO_GROUPBY("tblServices.ClientID")

                Case 1

                    ehq.ADD_TO_SELECT("ClientID")
                    ehq.ASSIGN_FROM_STATEMENT("tblClients")
                    ehq.ADD_TO_WHERE("ClientID>=29")

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
    Public Sub UPDATE_Client(r As DataRow)
        Try

            Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "")

        End Try
    End Sub
End Class
