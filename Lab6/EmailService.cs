using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    public abstract class EmailService : IEmailSender
    {
        private readonly string _smtpServer;
        private string _receiver;
        private string _messageText;
        private string _sender;
        private string _recipient;
        private string _message;
        private bool _isSent = false;
        protected EmailService(string smtpServer, string receiver, string messageText, string sender)
        {

            SmtpServer = smtpServer;
            Receiver = receiver;
            MessageText = messageText;
            Sender = sender;
        }
        public string SmtpServer
        {
            get => _smtpServer;
            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _smtpServer = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect name.");
                }
            }
        }

        public string Receiver
        {
            get => _receiver;
            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _receiver = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect name.");
                }
            }
        }

        public string MessageText
        {
            get => _messageText;
            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _messageText = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect name.");
                }
            }
        }

        public string Sender
        {
            get => _sender;
            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _sender = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect name.");
                }
            }
        }

        public string Recipient
        {
            get => _recipient;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _recipient = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect Recipient.");
                }
            }
        }

        public string Message
        {
            get => _message;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _message = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect Message.");
                }
            }
        }
        private bool IsSent
        {
            get => _isSent;
            set => _isSent = value;
        }

        public void SendEmail(string recipient, string message)
        {
            Recipient = recipient;
            Message = message;

            if (!IsSent)
            {
                IsSent = true;
            }
        }

        public void ReceiveEmail()
        {
            if (IsSent)
            {
                IsSent = false;
            }
        }


        public override string ToString()
        {
            return $"\nSMTP-сервер: {SmtpServer}\nАдрес получателя: {Receiver};\nПолный текст сообщения: {MessageText};\nОтправитель: {Sender};\n\n";
        }

    }
}