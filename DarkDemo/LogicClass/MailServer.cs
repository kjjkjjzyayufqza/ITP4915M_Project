using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
namespace DarkDemo
{
    class MailServer
    {
        private static Random random = new Random();
        public async Task sendMail(string reciverMail, string subject,string message)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(Helper.GetComMailInfo("emailAddress"));
                    mail.To.Add(reciverMail);
                    mail.Subject = subject;
                    mail.IsBodyHtml = true;
                    mail.Body = message;
                    await Task.Run(() => ConnectMailServerAsync(mail));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string genCode()
        {
            int codeLength = 6;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, codeLength)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void ConnectMailServerAsync(MailMessage mail)
        {
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new System.Net.NetworkCredential(Helper.GetComMailInfo("emailAddress"), Helper.GetComMailInfo("emailPassword"));
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
        }
    }
}
