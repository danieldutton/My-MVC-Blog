﻿namespace DansBlog.Services.Email.Model
{
    public class EmailSettings
    {
        public string SmtpServer { get; private set; }

        public string TargetEmail { get; private set; }


        public EmailSettings(string smtpServer, string targetEmail)
        {
            SmtpServer = smtpServer;
            TargetEmail = targetEmail;
        }
    }
}
