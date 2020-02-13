Imports EH_DataUtilities
Imports CD_Reports_MiddleTier.mt_LookUps

Public Class QuarterlyBoardReport
    Private indID As Integer
    Private OthInd As Object
    Private isCluster As Boolean
    Private clusterTitle As Object
    Private progName As String
    Private Sum As Single
    Private Sum_Projected As Single
    'Select Year here:
    Public Property iYear As Integer = 2018
    'Select MonthOrdinal here:
    Private StartMonthOrdinal As Integer = 25 'January 0f 2018
    Private counter As Integer = 0
    Private quarter As Integer
    Private OriginalStartMonthOrdinal As Integer

    Public Sub Fill_Data_Table()

        Dim dt_definitions As New DataTable
        Delete_all_records_from_table_holding_data()
        dt_definitions = Attach_report_definitions_to_datatable()
        OriginalStartMonthOrdinal = StartMonthOrdinal

        Do While counter < 4  'counter starts at 0

            StartMonthOrdinal = OriginalStartMonthOrdinal + (3 * counter)
            quarter = counter + 1

            Dim IndWhereStatement As String
            Dim ehq2 As New EH_QueryBuilder

            For Each row In dt_definitions.Rows

                Pull_indicator_number_and_other_relevant_info_from_each_row(row)
                isCluster = Determine_whether_row_is_single_or_cluster()
                IndWhereStatement = Determine_where_statement_depending_on_indicators_in_the_cluster()
                ehq2 = Create_select_query_for_each_row(IndWhereStatement)
                Determine_the_performance_and_target_values_from_the_query(ehq2)
                progName = Determine_program_name_based_on_cluster()
                Insert_results_into_report_data_table(Sum, Sum_Projected)

            Next


            counter = counter + 1
        Loop

        MessageBox.Show("Done")

    End Sub
    Private Function Determine_whether_row_is_single_or_cluster() As Boolean


        If IsDBNull(OthInd) Then
            Return False
        ElseIf OthInd.ToString = "" Then
            Return False
        Else
            Return True
        End If

    End Function
    Private Function Determine_where_statement_depending_on_indicators_in_the_cluster() As String

        Dim InitStatement As String = "tblIndicators.IndicatorID = " & indID.ToString
        Dim sOthInd As String

        If isCluster Then
            sOthInd = OthInd.ToString
            sOthInd = InitStatement & " OR tblIndicators.IndicatorID = " & sOthInd
            sOthInd = Replace(sOthInd, ", ", " OR tblIndicators.IndicatorID = ")
            Return sOthInd
        Else
            Return InitStatement
        End If


    End Function
    Private Function Determine_program_name_based_on_cluster() As String


        If isCluster Then
            Return clusterTitle
        Else
            Return LOOKUP_ProgramNameFromProgramID(LOOKUP_ProgramIDFromIndicatorID(indID))
        End If

    End Function
    Private Sub Delete_all_records_from_table_holding_data()

        Dim ehq4_DeleteAllRecordsFromReportDataTable As New EH_QueryBuilder

        ehq4_DeleteAllRecordsFromReportDataTable.ASSIGN_FIRST_LINE("delete from tblQuarterlyBoardReport_data")
        ehq4_DeleteAllRecordsFromReportDataTable.EXECUTE_NONQUERY()

    End Sub
    Private Function Attach_report_definitions_to_datatable() As DataTable

        Dim ehq_OpenDefinitionsTable As New EH_QueryBuilder

        ehq_OpenDefinitionsTable.ADD_TO_SELECT("*")
        ehq_OpenDefinitionsTable.ASSIGN_FROM_STATEMENT("tblQuarterlyBoardReport_definition")
        Return ehq_OpenDefinitionsTable.ATTACH_TO_DATATABLE

    End Function
    Private Function Create_select_query_for_each_row(WhereStatement As String) As EH_QueryBuilder


        Dim ehq2 As New EH_QueryBuilder

        ehq2.RESET_ALL()
        ehq2.ADD_TO_SELECT("tblIndicators.IndicatorID, Sum(tblMonthlyBenchmarks.PerformanceValue) As SumOfPerformanceValue, Sum(tblMonthlyBenchmarks.TargetValue) As SumOfTargetValue")
        ehq2.ASSIGN_FROM_STATEMENT("(tblIndicators INNER JOIN tblPrograms On tblIndicators.ProgramID = tblPrograms.ProgramID) INNER JOIN tblMonthlyBenchmarks On tblIndicators.IndicatorID = tblMonthlyBenchmarks.IndicatorID")
        ehq2.ADD_TO_WHERE("tblMonthlyBenchmarks.MonthID >= " & StartMonthOrdinal)
        ehq2.ADD_TO_WHERE("tblMonthlyBenchmarks.MonthID <= " & (StartMonthOrdinal + 2))
        ehq2.ADD_TO_GROUPBY("tblIndicators.IndicatorID")
        ehq2.ADD_TO_HAVING(WhereStatement)
        ehq2.ADD_TO_HAVING("Sum(tblMonthlyBenchmarks.PerformanceValue) is not null")

        Return ehq2


    End Function
    Private Sub Pull_indicator_number_and_other_relevant_info_from_each_row(row As DataRow)

        indID = row("IndicatorID")
        OthInd = row("OtherIndicators")
        clusterTitle = row("ClusterTitle")

    End Sub
    Private Sub Determine_the_performance_and_target_values_from_the_query(ehq2 As EH_QueryBuilder)

        Dim Sum2 As Decimal = 0.0
        Dim Sum_Projected2 = 0.0

        Dim dt2 As DataTable


        If ehq2.RECORD_COUNT > 0 Then

            If ehq2.RECORD_COUNT > 1 Then
                Sum2 -= Sum2
            End If

            dt2 = ehq2.ATTACH_TO_DATATABLE
            Sum2 = 0.0
            Sum_Projected2 = 0.0

            For Each row2 In dt2.Rows

                If (Not IsDBNull(row2.item("SumOfPerformanceValue"))) Then
                    Sum2 = Sum2 + Convert.ToDecimal(row2.item("SumOfPerformanceValue"))
                End If

                If (Not IsDBNull((row2.Item("SumOfTargetValue")))) Then
                    Sum_Projected2 = Sum_Projected2 + Convert.ToDecimal(row2.item("SumOfTargetValue"))
                End If
            Next

        End If

        Sum = Sum2
        Sum_Projected = Sum_Projected2

    End Sub
    Private Sub Insert_results_into_report_data_table(sum3 As Single, sum3_projected As Single)
        Dim ehq3 As New EH_QueryBuilder

        ehq3.RESET_ALL()

            If counter = 0 Then
                ehq3.ASSIGN_FIRST_LINE("INSERT INTO tblQuarterlyBoardReport_data ( Department, Program, [Indicator], [Q" & quarter & "_Total], IndicatorID, PercentageOrAverage, IndicatorOrder, Q" & quarter & "_Projected)" &
            " Select tblDepartments.Department, '" & progName & "', tblIndicators.Indicator, " & sum3 & ", " & indID & ", tblIndicators.PercentageOrAverage, tblIndicators.IndicatorOrder, " & sum3_projected)
                ehq3.ASSIGN_FROM_STATEMENT(" tblMonths, (tblIndicators INNER Join tblPrograms On tblIndicators.ProgramID = tblPrograms.ProgramID) INNER Join tblDepartments On tblPrograms.DepartmentID = tblDepartments.DepartmentID")
                ehq3.ADD_TO_GROUPBY("tblDepartments.Department, tblPrograms.Program, tblIndicators.Indicator, PercentageOrAverage, IndicatorOrder ")
                ehq3.ADD_TO_WHERE("tblIndicators.IndicatorID = " & indID)
            Else
                ehq3.ASSIGN_FIRST_LINE("UPDATE tblQuarterlyBoardReport_data SET Q" & quarter & "_Total = " & sum3 & ", Q" & quarter & "_Projected = " & sum3_projected)
                ehq3.ADD_TO_WHERE("IndicatorID = " & indID)
            End If

        ehq3.EXECUTE_NONQUERY()

    End Sub
End Class
