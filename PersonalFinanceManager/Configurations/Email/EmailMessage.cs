namespace PersonalFinanceManager.Configurations.Email
{
    public class EmailMessage
    {
        public string To { get; set; } = string.Empty;
        public string From { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public bool IsBodyHtml { get; set; }
        public List<EmailAttachment> Attachments { get; set; } = new List<EmailAttachment>();
        public EmailMessage(string to, string subject, string body, bool isBodyHtml = false)
        {
            To = to;
            Subject = subject;
            Body = body;
            IsBodyHtml = isBodyHtml;
        }
    }
    public class EmailAttachment
    {
        public byte[]? Content { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
    }
}
