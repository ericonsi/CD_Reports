Imports CD_Reports.pt_Winforms
Public Class frmMain1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim ptw As New pt_Winforms
        ptw.CALL_PROCEDURE_CreateList()

    End Sub
End Class