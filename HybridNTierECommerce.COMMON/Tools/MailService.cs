using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.COMMON.Tools
{
    public static class MailService
    {



        //Mail : yzlm3170@gmail.com
        //Sifresi : BilgeAdam123

        //Mail'inizi baska projeler üzerinden kullanılarak mail gönderme sisteminde aktifleştirmek icin  önce o Mail'e girin
        //Manage your Google Account'a girin
        //Security'i secin
        //Karsınıza Signing in to Google kısmında 2-Step Verification cıkacak
        //Alt tarafta Application Password'ler var orada generate secenegini secin

        public static void Send(string receiver, string password = "oktczfjzfohickzn", string body = "Test mesajıdır", string subject = "Email testi", string sender = "yzlm3170@gmail.com")
        {
            MailAddress senderEmail = new(sender);
            MailAddress receiverEmail = new(receiver);

            //Bizim Email işlemlerimiz SMTP'ye göre yapılır...
            //Kullandıgınız gmail hesabınızın baska uygulamalar tarafından mesaj gönderme sistemini acmanız lazım

            SmtpClient smtp = new()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)

            };


            using (MailMessage message = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }





        }
    }
}
