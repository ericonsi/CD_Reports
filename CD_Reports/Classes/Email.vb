Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Net.Mail
Imports System.Net
Imports EH_ExceptionTrapping.EH_Exceptions
Public Class Email
    Public Interface ISendEmailMessage

        Property subject As String
        Property body As String
        Property msg_recipient As String
        Property msg_sender As String
        Property isBodyHtml As Boolean
        Property host As String
        Property port As String
        Property enableSsl As Boolean
        Property useDefaultCredentials As Boolean
        Property networkCredentialsEmail As String
        Property networkCredentialsPassword As String

        Sub SendEmail()

    End Interface



    Public Class SendEmailMessage_Local : Implements ISendEmailMessage

        Property subject As String Implements ISendEmailMessage.subject
        Property body As String = "Test" Implements ISendEmailMessage.body
        Property msg_recipient As String = "ehirsch2000@gmail.com" Implements ISendEmailMessage.msg_recipient
        Property msg_sender As String = "chasifundingtargets@gmail.com" Implements ISendEmailMessage.msg_sender
        Property isBodyHtml As Boolean = True Implements ISendEmailMessage.isBodyHtml
        Property host As String = "smtp.gmail.com" Implements ISendEmailMessage.host
        Property port As String = "465" Implements ISendEmailMessage.port
        Property enableSsl As Boolean = True Implements ISendEmailMessage.enableSsl
        Property useDefaultCredentials As Boolean = False Implements ISendEmailMessage.useDefaultCredentials
        Property networkCredentialsEmail As String = "chasifundingtargets@gmail.com" Implements ISendEmailMessage.networkCredentialsEmail
        Property networkCredentialsPassword As String = "chasi12345" Implements ISendEmailMessage.networkCredentialsPassword

        Public Sub SendEmail() Implements ISendEmailMessage.SendEmail

            Dim msg As MailMessage = New MailMessage()
            Dim client As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient()
            Dim basicauthenticationinfo As System.Net.NetworkCredential = New System.Net.NetworkCredential(networkCredentialsEmail, networkCredentialsPassword)

            msg.Subject = subject
            msg.Body = body
            msg.From = New MailAddress(msg_sender)
            msg.To.Add(msg_recipient)
            msg.IsBodyHtml = False
            client.Host = host
            client.Port = CInt(port)
            client.EnableSsl = enableSsl
            client.UseDefaultCredentials = useDefaultCredentials
            client.Credentials = basicauthenticationinfo
            client.DeliveryMethod = SmtpDeliveryMethod.Network
            client.Send(msg)

        End Sub
    End Class
End Class