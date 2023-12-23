using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;

namespace CV_Project.Mail
{
    public class MailHelper
    {
        public static bool SendMail(string body, string to, string subject, bool isHtml = true)
        {
            return SendMail(body, new List<string> { to }, subject, isHtml);
        }

        public static bool SendMail(string body, List<string> to, string subject, bool isHtml = true)
        {
            bool result = false;

            try
            {
                var message = new MailMessage();
                message.From = new MailAddress("test_altan_emre_1989@hotmail.com");

                to.ForEach(x =>
                {
                    message.To.Add(new MailAddress(x));
                });

                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = isHtml;

                using (var smtp = new SmtpClient(
                    "stmp-mail.outlook.com",587
                   
                    ))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials =
                        new NetworkCredential("test_altan_emre_1989@hotmail.com","UBY12345"


                    smtp.Send(message);
                    result = true;
                }
            }
            catch (Exception)
            {

                //
            }

            return result;
        }
    }
}