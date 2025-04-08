using System.Net.Mail;
using PersonalFinanceManager.Configurations.Email;

namespace PersonalFinanceManager.Services.EmailService
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string body, bool isBodyHtml = false);
        Task SendEmailAsync(string to, string subject, string body, string from, bool isBodyHtml = false);
        Task SendEmailAsync(EmailMessage message);
    }
}
