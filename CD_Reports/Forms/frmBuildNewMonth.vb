Imports CD_Reports_MiddleTier
Imports CD_Reports_MiddleTier.mt_LookUps
Public Class frmBuildNewMonth
    Private Sub TblDepartmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblDepartmentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblDepartmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CD_ReportsDataSet)

    End Sub

    Private Sub frmBuildNewMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CD_ReportsDataSet.tblMonthlyBenchmarks' table. You can move, or remove it, as needed.
        Me.TblMonthlyBenchmarksTableAdapter.Fill(Me.CD_ReportsDataSet.tblMonthlyBenchmarks)
        Me.TblIndicatorsTableAdapter.Fill(Me.CD_ReportsDataSet.tblIndicators)
        Me.TblProgramsTableAdapter.Fill(Me.CD_ReportsDataSet.tblPrograms)
        Me.TblDepartmentsTableAdapter.Fill(Me.CD_ReportsDataSet.tblDepartments)

        Dim ptw As New CD_Reports.pt_Winforms
        ptw.Assign_SourceQuery_To_cmbMonths(Me.cmbMonths)

    End Sub

    Private Sub btnBuildMonth_Click(sender As Object, e As EventArgs) Handles btnBuildMonth.Click

        Try
            Me.Validate()
            Me.TblDepartmentsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CD_ReportsDataSet)

            Dim mtd As New mt_data.DataEntryUpdateAndDelete
            mtd.BuildNewMonth(Me.cmbMonths.SelectedValue)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "Something has gone wrong with the month build.  The build has failed.")
        End Try

    End Sub
    Private Sub dgvBuildNewMonth_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

        Dim DataError As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.DataErrorHandler
        Dim InvalidCast As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.InvalidCastHandler

        If e.Context = 4864 Then
            InvalidCast.HANDLE_EXCEPTION(e.Exception, LOOKUP_RunConditionalTrace, "When inputting targets, only numbers are allowed - no symbols (such as a '%' or '$') or text.  For numbers over a thousand do not include the comma (i.e. '1200', not '1,200')", "CastError from dgvMonthlyBenchmarks")
        Else
            DataError.HANDLE_EXCEPTION(e.Exception, True, "", "DataError from dgvMonthlyBenchmarks")
        End If

    End Sub
    Private Sub dgvDepartments_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles TblDepartmentsDataGridView.DataError

        Dim DataError As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.DataErrorHandler
        Dim InvalidCast As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.InvalidCastHandler

        If e.Context = 4864 Then
            InvalidCast.HANDLE_EXCEPTION(e.Exception, LOOKUP_RunConditionalTrace, "When inputting targets, only numbers are allowed - no symbols (such as a '%' or '$') or text.  For numbers over a thousand do not include the comma (i.e. '1200', not '1,200')", "CastError from dgvMonthlyBenchmarks")
        Else
            DataError.HANDLE_EXCEPTION(e.Exception, True, "", "DataError from dgvMonthlyBenchmarks")
        End If

    End Sub

    Private Sub frmBuildNewMonth_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try

            Me.Validate()
            Me.TblDepartmentsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CD_ReportsDataSet)
            'Me.TblIndicatorsDataGridView.Refresh()
            Me.TblDepartmentsDataGridView.Refresh()
            Me.TblProgramsDataGridView.Refresh()

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
        HandleStandardException.HANDLE_EXCEPTION(ex, True, "Something has gone wrong with the month build.  The build has failed.")
        End Try

    End Sub

End Class