using GroceryShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Services
{
        public class EmailHelper
        {
            private EmailSettings _emailSettings;
            public EmailHelper(EmailSettings _emailSettings)
            {
                this._emailSettings = _emailSettings;
            }

            public bool SendMail(string recipient, string subject, string cc)
            {
                try
                {
                    MailMessage mail = new MailMessage()
                    {
                        From = new MailAddress("msauder3@learn.bcit.ca", "Michelle Sauder")
                    };

                    string toEmail = string.IsNullOrEmpty(recipient)
                                     ? _emailSettings.ToEmail : recipient;

                    mail.To.Add(new MailAddress(toEmail));
                    mail.CC.Add(new MailAddress(cc));

                    // Subject and multipart/alternative Body
                    mail.Subject = subject;

                    string text = "Plain text version of a message body. ";
                    string html = @"<p>HTML version of a message body. </p>";

                    mail.AlternateViews.Add(
                            AlternateView.CreateAlternateViewFromString(text,
                            null, MediaTypeNames.Text.Plain));
                    mail.AlternateViews.Add(
                            AlternateView.CreateAlternateViewFromString(html,
                            null, MediaTypeNames.Text.Html));

                    //optional priority setting
                    mail.Priority = MailPriority.High;
                    // you can add attachments
                    //.Attachments.Add(new Attachment(@"C:\mind.gif"));
                    // Init SmtpClient and send
                    SmtpClient smtp = new SmtpClient(_emailSettings.Domain, _emailSettings.Port);
                    smtp.Credentials = new NetworkCredential(_emailSettings.UsernameEmail, _emailSettings.UsernamePassword);
                    smtp.EnableSsl = false;
                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
        }
    }
