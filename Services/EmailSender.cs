// Services/EmailSender.cs
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

public interface IEmailSender
{
    Task SendEmailAsync(string toEmail, string subject, string message);
}

public class EmailSender : IEmailSender
{
    private readonly SmtpSettings _smtpSettings;

    public EmailSender(IOptions<SmtpSettings> smtpSettings)
    {
        _smtpSettings = smtpSettings.Value;
    }

    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {
        var client = new SmtpClient(_smtpSettings.Server, _smtpSettings.Port)
        {
            Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
            EnableSsl = true
        };

        var mailMessage = new MailMessage
        {
            From = new MailAddress(_smtpSettings.SenderEmail, _smtpSettings.SenderName),
            Subject = subject,
            Body = message,
            IsBodyHtml = true,
        };

        mailMessage.To.Add(toEmail);

        await client.SendMailAsync(mailMessage);
    }
}
