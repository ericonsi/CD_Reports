Imports EH_DataUtilities.EH_QueryBuilder
Imports CD_Reports.pt_Retrieve
Imports System.Windows.Forms
Imports System.Data.SqlClient

Namespace pt_Data

    Public Class GetSourceQueriesForDGVsAndCombos

        Public Function Get_SourceQuery_For_dgvMonthlyBenchmarks() As DataTable

            Dim ehq As New EH_DataUtilities.EH_QueryBuilder

            ehq.ADD_TO_SELECT("MonthlyBenchmarkID, tblIndicators.Indicator, tblMonthlyBenchmarks.MonthID, tblMonthlyBenchmarks.IndicatorID, PerformanceValue, TargetValue, tblMonthlyBenchmarks.data_enterer, tblMonthlyBenchmarks.insertion_date, tblMonthlyBenchmarks.Details, tblMonthlyBenchmarks.bOptional")
                ehq.ASSIGN_FROM_STATEMENT("(tblIndicators INNER JOIN tblMonthlyBenchmarks On tblIndicators.IndicatorID = tblMonthlyBenchmarks.IndicatorID) INNER JOIN tblPrograms On tblIndicators.ProgramID = tblPrograms.ProgramID")
                ehq.ADD_TO_WHERE("tblPrograms.ProgramID = " & RETRIEVE_SelectedProgramID())
                ehq.ADD_TO_WHERE("MonthID = " & RETRIEVE_SelectedMonthIDfromFrmMain())
            ehq.ADD_TO_ORDERBY("tblindicators.IndicatorOrder")

            If RETRIEVE_All_Or_Selected_ForIndicators() = "Selected" Then ehq.ADD_TO_WHERE("tblIndicators.Include =" & 1)


            Dim dt As DataTable = ehq.ATTACH_TO_DATATABLE
            Return dt

        End Function

        Public Function Get_SourceQuery_For_cmbMonths() As DataTable

            Try

                Dim ehq As New EH_DataUtilities.EH_QueryBuilder
                ehq.ADD_TO_SELECT(" tblMonths.MonthID, tblMonths.Month_Ordinal, tblMonths.Year + '-' + tblMonths.Month AS Legible_Date")
                ehq.ASSIGN_FROM_STATEMENT("tblMonths")

                Dim dt As DataTable = ehq.ATTACH_TO_DATATABLE
                Return dt

            Catch ex As Exception
                Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
                HandleStandardException.HANDLE_EXCEPTION(ex, True, "Something has gone wrong with the Months combo box.  Exit out and try again.")
            End Try

        End Function
    End Class
End Namespace
