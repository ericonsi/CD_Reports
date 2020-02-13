Imports System.Data.SqlClient
Public Class mt_StoredProcedures
    Public Sub SP_UpdateDatabaseFromDgvMonthlyBenchmarks(MonthlyBenchmarkID As Integer, PerformanceValue As Integer, Details As String, TargetValue As String, bOptional As Boolean)

        Try

            Dim EHSP As New EH_DataUtilities.EH_SQLSERVER_StoredProcedures

            EHSP.ASSIGN_PROCEDURE_NAME("sprUpdateMonthlyBenchmarks")
            EHSP.ADD_PARAMETER("MonthlyBenchmarkID", SqlDbType.Int, ParameterDirection.Input, MonthlyBenchmarkID)
            EHSP.ADD_PARAMETER("PerformanceValue", SqlDbType.Int, ParameterDirection.Input, PerformanceValue)
            EHSP.ADD_PARAMETER("Details", SqlDbType.NVarChar, ParameterDirection.Input, Details)
            EHSP.ADD_PARAMETER("TargetValue", SqlDbType.Decimal, ParameterDirection.Input, TargetValue)
            EHSP.ADD_PARAMETER("bOptional", SqlDbType.Bit, ParameterDirection.Input, bOptional)

            EHSP.EXECUTE_PROCEDURE()

        Catch sqex As SqlException
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.BasicHandler
            HandleStandardException.HANDLE_EXCEPTION(sqex, True, "Something has gone wrong.  It's quite possible your changes aren't being saved properly.  Exit out and enter back in to see if your changes are there - if not, exit the database and contact your DB administrator.")
        End Try

    End Sub

End Class
