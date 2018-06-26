using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SMTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
           // string address =Console.ReadLine();
          //  string patch = Directory.GetCurrentDirectory();
          for(int i=0;i<5;i++)
            {
             sendMailAsync().GetAwaiter();
            
            }
           

            Console.Read();


        }
        public static async Task sendMailAsync()
        {
            MailAddress from = new MailAddress("hello@gmail.com", "Check");
            MailAddress to = new MailAddress("aubury@ukr.net");
            MailMessage message = new MailMessage(from, to);

            message.Subject = "Check";
            message.IsBodyHtml = true;
            message.Body = "<h1><p style='color:blue>Сheck for exchange is attached to the letter</p></h1>";
           message.Attachments.Add(new Attachment(@"D:\ПРОГРАММИРОВАНИЕ\4_семестр\Сетевое программирование\3_УРОК\Exchage\Exchage\bin\Debug\Check.txt"));

            //SmtpClient smtpClient = new SmtpClient("aspmx.1.google.com", 25);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new NetworkCredential("pp16v3@gmail.com", "pp16v3pp16v3");
            smtpClient.EnableSsl = true;
            
            try
            {
              // smtpClient.Send(message);
               await smtpClient.SendMailAsync(message);
                Console.WriteLine("Mail send");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Mail not send  " + ex.Message);
            }
            
        }
    }
}
