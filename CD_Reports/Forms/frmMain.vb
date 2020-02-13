Imports EH_ExceptionTrapping
Imports System.Data.SqlClient
Imports CD_Reports_MiddleTier.mt_LookUps
Imports EH_DataUtilities.GeneralDataFunctions
Imports CD_Reports.pt_Retrieve
Imports CD_Reports_MiddleTier.mt_Data
Imports CD_Reports_MiddleTier.mt_Validation
Public Class frmMain

    Public sOldValue_Indicator As String = ""
    Public sNewValue_Indicator As String = ""
    Public iIndicatorID As Integer
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim TraceLogin As New EH_ExceptionTrapping.TraceDebugMethods
        TraceLogin.EH_WindowsTraceLogMessage("Login -", "X:\Trace Files\NewSTDB_Logins.txt", Environment.UserName)

        Me.VwLegible_MonthTableAdapter.Fill(Me.CD_ReportsDataSet.vwLegible_Month)
        Me.TblMonthlyBenchmarksTableAdapter.Fill(Me.CD_ReportsDataSet.tblMonthlyBenchmarks)
        Me.TblProgramsTableAdapter.Fill(Me.CD_ReportsDataSet.tblPrograms)
        Me.TblDepartmentsTableAdapter.Fill(Me.CD_ReportsDataSet.tblDepartments)
        Me.TblMonthsTableAdapter.Fill(Me.CD_ReportsDataSet.tblMonths)
        Me.TblMonths1TableAdapter.Fill(Me.CD_ReportsDataSet.tblMonths1)

        MessageBox.Show("Make sure you select the correct month and year.")

        Me.cmbMonth.SelectedIndex = RETRIEVE_month_ordinal_for_now_month_minus_one()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShowIndicators.Click

        Try

            Dim ptw As New pt_Winforms
            ptw.Assign_SourceQuery_To_dgvMonthlyBenchmarks()
            Me.btnShowIndicators.Hide()
            Me.pnlIndicatorSelect.Visible = False

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "There is an error in the indicators; they cannot be shown.")
        End Try

    End Sub

    Private Sub dgvMonthlyBenchmarks_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvMonthlyBenchmarks.RowValidating

        Try

            Dim mts As New CD_Reports_MiddleTier.mt_StoredProcedures

            If dgvMonthlyBenchmarks.IsCurrentRowDirty And VALIDATE_that_BenchMarkID_is_not_null(sender, e) Then
                Dim iMonthlyBenchmarkID As String = dgvMonthlyBenchmarks.Rows(e.RowIndex).Cells("MonthlyBenchmarkID").Value

                If IsDBNull(dgvMonthlyBenchmarks.Rows(e.RowIndex).Cells("TargetValue").Value) Then
                    MessageBox.Show("You can't leave the target field blank.  Put a zero if there is no target.")
                    e.Cancel = True
                    Exit Sub
                End If

                Dim iPerformanceValue As String
                If IsDBNull(dgvMonthlyBenchmarks.Rows(e.RowIndex).Cells("PerformanceValue").Value) Then
                    iPerformanceValue = "0"
                Else
                    iPerformanceValue = dgvMonthlyBenchmarks.Rows(e.RowIndex).Cells("PerformanceValue").Value
                End If

                Dim dTargetValue As String
                If IsDBNull(dgvMonthlyBenchmarks.Rows(e.RowIndex).Cells("TargetValue").Value) Then
                    dTargetValue = "0"
                Else
                    dTargetValue = dgvMonthlyBenchmarks.Rows(e.RowIndex).Cells("TargetValue").Value
                End If

                Dim bOptional As String
                If IsDBNull(dgvMonthlyBenchmarks.Rows(e.RowIndex).Cells("bOptional").Value) Then
                    bOptional = "0"
                Else
                    bOptional = dgvMonthlyBenchmarks.Rows(e.RowIndex).Cells("bOptional").Value
                End If

                Dim sDetails As String
                If IsDBNull(dgvMonthlyBenchmarks.Rows(e.RowIndex).Cells("Details").Value) Then
                    sDetails = ""
                Else
                    sDetails = dgvMonthlyBenchmarks.Rows(e.RowIndex).Cells("Details").Value
                End If

                mts.SP_UpdateDatabaseFromDgvMonthlyBenchmarks(iMonthlyBenchmarkID, iPerformanceValue, sDetails, dTargetValue, bOptional)
            End If

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "Something has gone wrong.  Your changes may not have saved properly.")
        End Try

    End Sub
    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged

        cmbDepartment.DataSource = TblDepartmentsBindingSource
        Reset_Dgv_When_Inputs_change()

    End Sub

    Private Sub cmbProgram_SelectedIndexChanged(sender As Object, e As EventArgs)

        Reset_Dgv_When_Inputs_change()

    End Sub

    Private Sub Reset_Dgv_When_Inputs_change()

        Try

            Me.dgvMonthlyBenchmarks.DataSource = ""
            Me.btnShowIndicators.Visible = True
            Me.pnlIndicatorSelect.Visible = True


        Catch ex As Exception
            Dim HandleGlobalException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.GlobalHandler
            HandleGlobalException.HANDLE_EXCEPTION(ex, True)
            Application.Exit()
        End Try

    End Sub

    Private Sub cmbDepartment_Click(sender As Object, e As EventArgs) Handles cmbDepartment.Click

        Me.TblDepartmentsTableAdapter.Fill(Me.CD_ReportsDataSet.tblDepartments)
        Reset_Dgv_When_Inputs_change()

    End Sub
    Private Sub dgvPrograms_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrograms.CellContentClick

        Reset_Dgv_When_Inputs_change()

    End Sub

    Private Sub OpenReportServer(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

        'Opens reports

        Try

            MsgBox("When prompted for your username, be sure to put 'CHASI\' in front of it. That is a back-slash (\), not a forward-slash(/)." & Chr(13) & Chr(13) & "Please be patient. The report server MAY TAKE UP TO 1 MINUTE to load.")
            Process.Start(LOOKUP_ReportServerUrl)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.BasicHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, LOOKUP_RunConditionalTrace, "There is a problem with the report server.  You might try again later.")

        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Try

            Process.Start(LOOKUP_HelpFileLocation)

        Catch ex As Exception
            Dim HandlestandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandlestandardException.HANDLE_EXCEPTION(ex, True)
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Try

            Dim f As New frmAddDeleteModify
            f.Show()

        Catch ex As Exception
            Dim HandlestandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandlestandardException.HANDLE_EXCEPTION(ex, True)
        End Try

    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged
        Reset_Dgv_When_Inputs_change()
    End Sub

    Private Sub dgvPrograms_Click(sender As Object, e As EventArgs) Handles dgvPrograms.Click
        Reset_Dgv_When_Inputs_change()
    End Sub

    Private Sub cmbMonth_Click(sender As Object, e As EventArgs) Handles cmbMonth.Click
        Reset_Dgv_When_Inputs_change()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Try
            'password for admin functions
            Dim strPassword As String
            Dim ptw As New pt_Winforms

            strPassword = InputBox("Password?:")

            If strPassword = LOOKUP_ToolbarPassword() Then
                ptw.Enable_Toolstrip()
            Else
                MessageBox.Show("Password Incorrect.")
            End If

        Catch ex As Exception

            Dim mStandard As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            mStandard.HANDLE_EXCEPTION(ex, LOOKUP_RunConditionalTrace)

        End Try
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs)
        Try

            Dim f As New frmEmailFacility
            f.Show()

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True)
        End Try

    End Sub
    Private Sub dgvMonthlyBenchmarks_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvMonthlyBenchmarks.DataError

        Dim DataError As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.DataErrorHandler
        Dim InvalidCast As New EH_Exceptions.Exception_Handlers.InvalidCastHandler

        If e.Context = 4864 Then
            InvalidCast.HANDLE_EXCEPTION(e.Exception, LOOKUP_RunConditionalTrace, "When inputting targets, only numbers are allowed - no symbols (such as a '%' or '$') or text.  For numbers over a thousand do not include the comma (i.e. '1200', not '1,200')", "CastError from dgvMonthlyBenchmarks")
        Else
            DataError.HANDLE_EXCEPTION(e.Exception, True, "", "DataError from dgvMonthlyBenchmarks")
        End If

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Try

            Dim f As New frmSettings
            f.Show()

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True)
        End Try
    End Sub

    Private Sub EnableEditing_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Try

            Dim ptw As New pt_Winforms

            If Me.btnShowIndicators.Visible = False Then

                ptw.Enable_Or_Not_Editing_Of_DGV(Me.dgvMonthlyBenchmarks, True)
                Me.dgvMonthlyBenchmarks.Columns("Indicator").ReadOnly = False

            End If

            'doesn't seem to work
            'ptw.Enable_Or_Not_Editing_Of_DGV(Me.dgvPrograms, True)
            'Me.dgvPrograms.Columns("Program").ReadOnly = False



        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True)
        End Try
    End Sub
    Private Sub dgvMonthlyBenchmarks_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvMonthlyBenchmarks.CellValidating
        Try


            '            Dim ehw As New EH_Winforms_Utilities.EH_DatagridViewFunctions.AssignOldAndNewValuesForUpdatinginCellValidating(sender, e)
            '
            '            sOldValue_Indicator = ehw.OldValue
            '            sNewValue_Indicator = ehw.NewValue
            '           'iIndicatorID = ehw.GET_ID("IndicatorID")
            ''           If Not IsDBNull(dgvMonthlyBenchmarks("IndicatorID", e.RowIndex).Value) Then
            '           iIndicatorID = dgvMonthlyBenchmarks("IndicatorID", e.RowIndex).Value
            '           End If
        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True)

        End Try

    End Sub

    Private Sub dgvMonthlyBenchmarks_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMonthlyBenchmarks.CellValidated
        Try

            'Dim mtd As New CD_Reports_MiddleTier.mt_Data.DataEntryUpdateAndDelete
            '
            '            If IsDBNull(dgvMonthlyBenchmarks("MonthlyBenchmarkID", e.RowIndex).Value) Then
            '
            '            'mtd.AddBenchmark()
            '
            '            ElseIf sOldValue_Indicator <> sNewValue_Indicator Then
            '
            '            'mtd.UpdateBenchmark(iIndicatorID, sOldValue_Indicator, sNewValue_Indicator)
            '
            '            End If

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True)

        End Try
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles btnBoardReport.Click

        Dim x As New CD_Reports_MiddleTier.QuarterlyBoardReport

        Try

            x.Fill_Data_Table()

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True)

        End Try

    End Sub
End Class
'Still to do: When a user uses enable editing a few problems occur: 1) the indicator updates to sNewValue which is whatver value was last selected, even if it isn't 
' the new indicator vale
'2) some fields in the dgv are still readonly
'Also, there is a new update query in sql server which will need to be copied over to hosted_apps
