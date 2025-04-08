namespace PersonalFinanceManager.Configurations.Email
{
    public class EmailMessage
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
        public List<EmailAttachment> Attachments { get; set; } = new List<EmailAttachment>();

        public EmailMessage() { }

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
        public byte[] Content { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
    }
}
