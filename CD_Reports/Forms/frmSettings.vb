Public Class frmSettings
    Private Sub TblSettingsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblSettingsBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.TblSettingsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CD_ReportsDataSet)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.BasicHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "The data is not saved.")
        End Try

    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Me.TblSettingsTableAdapter.Fill(Me.CD_ReportsDataSet.tblSettings)

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "The form won't open.")
        End Try

    End Sub
End Class