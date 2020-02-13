Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x As New CD_Reports_MiddleTier.QuarterlyBoardReport

        x.Fill_Data_Table()

    End Sub
End Class
