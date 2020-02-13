Imports CD_Reports_MiddleTier
Public Class frmAddDeleteModify
    Private Sub TblDepartmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblDepartmentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblDepartmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CD_ReportsDataSet)

    End Sub

    Private Sub frmAddDeleteModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            'mtd.AddDeleteModify(Me.cmbMonths.SelectedValue)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "Something has gone wrong with the month build.  The build has failed.")
        End Try

    End Sub
    Private Sub frmBuildNewMonth_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try

            Me.Validate()
            Me.TblDepartmentsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CD_ReportsDataSet)
            Me.TblIndicatorsDataGridView.Refresh()
            Me.TblDepartmentsDataGridView.Refresh()
            Me.TblProgramsDataGridView.Refresh()

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True)
        End Try

    End Sub

End Class