using System;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MimeKit;

namespace AdContact
{
    /*
     * Connects to, sends and retrieves messages from a mail server.
     */
    internal class MailConnector
    {
        private static readonly string ImapYandexUrl = "imap.yandex.com";
        private static readonly int ImapYandexPort = 993;
        private static readonly string SmtpYandexUrl = "smtp.yandex.com";
        private static readonly int SmtpYandexPort = 465;

        private readonly ImapClient _imap;
        private readonly SmtpClient _smtp;

        public MailConnector()
        {
            _imap = new ImapClient();
            _smtp = new SmtpClient();
        }

        public void ImapConnect(string login, string password)
        {
            try
            {
                _imap.Connect(ImapYandexUrl, ImapYandexPort, true);
                _imap.Authenticate(login, password);
            }
            catch (InvalidOperationException) 
            {
                _imap.Disconnect(true);
                ImapConnect(login, password);
            }
        }

        public void SmtpConnect(string login = null, string password = null)
        {
            try
            {
                _smtp.Connect(SmtpYandexUrl, SmtpYandexPort, true);

                if (login != null && password != null)
                {
                    _smtp.Authenticate(login, password);
                }
            }
            catch (InvalidOperationException) 
            {
                _smtp.Disconnect(true);
                SmtpConnect(login, password);
            }
        }

        public void Send(MimeMessage mes)
        {
            _smtp.Send(mes);
        }
    }
}
