﻿namespace PersonalFinanceManager.Configurations.Email
{
    public class SmtpSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool EnableSsl { get; set; }
        public string DefaultFromEmail { get; set; }
        public string DefaultFromName { get; set; }
    }
}
