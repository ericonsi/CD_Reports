Imports CD_Reports.Email
Public Class frmEmailFacility
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim msg = New Email.SendEmailMessage_Local

        msg.subject = "Hey!"
        msg.body = Me.TextBox1.Text
        msg.SendEmail()

    End Sub
End Class