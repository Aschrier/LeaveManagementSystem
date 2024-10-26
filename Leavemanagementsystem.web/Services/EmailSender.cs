using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace Leavemanagementsystem.web.Services
{
    public class EmailSender(IConfiguration _configuration) : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromAddress = _configuration["EmailSettings:DefaultEmailAddress"];
            var SmtpServer = _configuration["EmailSettings:Server"];
            var SmtpPort = Convert.ToInt32(_configuration["EmailSettings:Port"]);
            var message = new MailMessage
            {
                From = new MailAddress(fromAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            message.To.Add(new MailAddress(email));
            using var client = new SmtpClient(SmtpServer, SmtpPort);
            await client.SendMailAsync(message);
        }
    }
}
