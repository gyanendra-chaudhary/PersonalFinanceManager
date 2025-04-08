
using System.Net;
using System.Net.Mail;
using PersonalFinanceManager.Configurations.Email;

namespace PersonalFinanceManager.Services.EmailService
{
    public class EmailService : IEmailService
    {

        private readonly SmtpSettings _smtpSettings;

        public EmailService(SmtpSettings smtpSettings)
        {
            _smtpSettings = smtpSettings ?? throw new ArgumentNullException(nameof(smtpSettings));
        }

        public async Task SendEmailAsync(string to, string subject, string body, bool isBodyHtml = false)
        {
            var message = new EmailMessage
            {
                To = to,
                Subject = subject,
                Body = body,
                IsBodyHtml = isBodyHtml,
                From = _smtpSettings.DefaultFromEmail
            };

            await SendEmailAsync(message);
        }

        public async Task SendEmailAsync(string to, string subject, string body, string from, bool isBodyHtml = false)
        {
            var message = new EmailMessage
            {
                To = to,
                Subject = subject,
                Body = body,
                IsBodyHtml = isBodyHtml,
                From = from
            };

            await SendEmailAsync(message);
        }

        public async Task SendEmailAsync(EmailMessage message)
        {
            using (var smtpClient = CreateSmtpClient())
            using (var mailMessage = CreateMailMessage(message))
            {
                await smtpClient.SendMailAsync(mailMessage);
            }
        }

        private SmtpClient CreateSmtpClient()
        {
            return new SmtpClient(_smtpSettings.Host, _smtpSettings.Port)
            {
                Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                EnableSsl = _smtpSettings.EnableSsl,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
        }

        private MailMessage CreateMailMessage(EmailMessage message)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(message.From ?? _smtpSettings.DefaultFromEmail),
                Subject = message.Subject,
                Body = message.Body,
                IsBodyHtml = message.IsBodyHtml
            };

            mailMessage.To.Add(message.To);

            foreach (var attachment in message.Attachments)
            {
                var memoryStream = new MemoryStream(attachment.Content);
                var mailAttachment = new Attachment(memoryStream, attachment.FileName, attachment.ContentType);
                mailMessage.Attachments.Add(mailAttachment);
            }

            return mailMessage;
        }
    }
}
