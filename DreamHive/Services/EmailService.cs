﻿using System.Net;
using System.Net.Mail;

namespace DreamHive.Services
{
    public class EmailService
    {
        public void SendEmail(string? from, string? to, string? subject, string? body)
        {
            // Create a new MailMessage object
            MailMessage message = new MailMessage(from, to, subject, body);
            // Set the server and credentials for sending the email
            var password = "oxdzqdneoaxpqzsc";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("student24donotreply@gmail.com", password)
            };
        }
    }
}
