using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Exchage
{
    public  class Mail
    {
         
        public static async Task sendMailAsync(string mail)
        {
            Logger log = new Logger();
            MailAddress from = new MailAddress("hello@gmail.com", "Check");
            MailAddress to = new MailAddress(mail);
            MailMessage message = new MailMessage(from, to);

            message.Subject = "Check";
            message.IsBodyHtml = true;
            message.Body = "<h1><p style='color:blue'>Сheck for exchange is attached to the letter</p></h1>";
            message.Attachments.Add(new Attachment("Check.txt"));

            //SmtpClient smtpClient = new SmtpClient("aspmx.1.google.com", 25);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new NetworkCredential("pp16v3@gmail.com", "pp16v3pp16v3");
            smtpClient.EnableSsl = true;

            try
            {
                // smtpClient.Send(message);
                await smtpClient.SendMailAsync(message);
              
            }
            catch (Exception ex)
            {

               log.WriteLine("Mail not send  " + ex.Message);
            }

        }
    }

    }

