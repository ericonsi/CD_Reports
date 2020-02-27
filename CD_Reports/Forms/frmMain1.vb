Imports CD_Reports.pt_Winforms
Public Class frmMain1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            Dim ptw As New pt_Winforms
            ptw.CALL_PROCEDURE_CreateList()
            MessageBox.Show("The report has been prepared.  You can print it out from your application.")
            Application.Exit()

        Catch ex As Exception

            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True)

        End Try


    End Sub
End Class