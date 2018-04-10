using System.Net.Mail;

namespace MailExample.Mail
{
    public class MailSender
    {
        string server;
        string mail;
        int port;
        string user;
        string password;

        public MailSender()
        {
            server = "";
            mail = "";
            port = 0;
            user = "";
            password = "";
        }

        public void ConfigMailSender(string MailServer, string SenderMail, int Port, string MailUser, string MailPassword)
        {
            server = MailServer;
            mail = SenderMail;
            port = Port;
            user = MailUser;
            password = MailPassword;
        }

        public int SendMail(string destinator, string subject, string body)
        {
            try
            {
                MailMessage email = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(server);

                email.From = new MailAddress(mail);
                email.To.Add(destinator);
                email.Subject = subject;
                email.Body = body;

                SmtpServer.Port = port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(user, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(email);
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public int SendMail(string destinator, string subject, string body, string AttachmentFile)
        {
            try
            {
                MailMessage email = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(server);

                email.From = new MailAddress(mail);
                email.To.Add(destinator);
                email.Subject = subject;
                email.Body = body;

                Attachment attachment = new Attachment(AttachmentFile);
                email.Attachments.Add(attachment);

                SmtpServer.Port = port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(user, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(email);
                return 0;
            }
            catch
            {
                return 1;
            }
        }
    }
}
