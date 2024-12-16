using System.Net.Mail;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace Hotels.Services
{
    public class MailSender
    {
        private readonly ILogger<MailSender> logger;
        public MailSender(ILogger<MailSender> logger)
        {
            this.logger = logger;
        }
        public void EmailSender()
        {
            try
            {
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress("companyhotels0@gmail.com", "Hotels Company");
                message.To.Add("kasich.nszar@gmail.com");
                message.Subject = "Confirm message";
                message.Body = "<div style=\"color:red;\">Confirm message</div>";
                using(SmtpClient client = new SmtpClient("smpt.gmail.com"))
                {
                    client.Credentials = new NetworkCredential("companyhotels0@gmail.com", "Qwerty123@");
                    client.Port = 465;
                    client.EnableSsl = true;
                    client.Send(message);
                    logger.LogInformation("Message has been sent");
                }
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.GetBaseException().Message);
            }
        }
    }
}
