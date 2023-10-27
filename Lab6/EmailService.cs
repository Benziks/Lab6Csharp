using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    /// <summary>
    /// Абстрактный класс EmailService, который реализует интерфейс IEmailSender
    /// </summary>
    public abstract class EmailService : IEmailSender
    {
        private readonly string _smtpServer;
        private string _receiver;
        private string _messageText;
        private string _sender;
        private string _recipient;
        private string _message;
      

        /// <summary>
        /// Установка и получение поля SmtpServer(SMTP-сервер).
        /// Внутри происходит проверка на null.
        /// Если все успешно выведет название SMTP-сервер с удаленными пробелами(_smtpServer = value.Trim();).
        /// </summary>
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
                    throw new FormatException("Неверное название SMTP-сервер ");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля Receiver(Получатель).
        /// Внутри происходит проверка на null.
        /// Если все успешно выведет адресс Получателя с удаленными пробелами(_receiver = value.Trim();).
        /// </summary>

        public string Receiver
        {
            get => _receiver;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _receiver = value.Trim();
                }
                else
                {
                    throw new FormatException("Неверный адресс получателя");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля MessageText(Текст письма).
        /// Внутри происходит проверка на null.
        /// Если все успешно выведет текст письма с удаленными пробелами(_messageText = value.Trim();).
        /// </summary>
        public string MessageText
        {
            get => _messageText;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _messageText = value.Trim();
                }
                else
                {
                    throw new FormatException("Неверный текст письма");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля Sender(Отправитель).
        /// Внутри происходит проверка на null.
        /// Если все успешно выведет адресс отправителя с удаленными пробелами(_sender = value.Trim();).
        /// </summary>
        public string Sender
        {
            get => _sender;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _sender = value.Trim();
                }
                else
                {
                    throw new FormatException("Неверный адресс отправителя");
                }
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса EmailService.
        /// </summary>
        /// <param name="smtpServer">SMTP-сервер</param>
        /// <param name="receiver">Получатель</param>
        /// <param name="messageText">Текст письма</param>
        /// <param name="sender">Отправитель</param>
        protected EmailService(string smtpServer, string receiver, string messageText, string sender)
        {

            SmtpServer = smtpServer;
            Receiver = receiver;
            MessageText = messageText;
            Sender = sender;
        }

        /// <summary>
        /// Свойство Recipient класса в котором находится получатель, возвращает Incorrect Recipient, если пытаемся присвоить пустую строку.
        /// </summary>
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

        /// <summary>
        /// Свойство Message класса в котором находится текст, возвращает Incorrect Message, если пытаемся присвоить пустую строку.
        /// </summary>
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

        /// <summary>
        /// Свойство IsSent класса в котором находится статус письма(отправлено\получено).
        /// </summary>

        public abstract void SendEmail(string recipient, string message);


        public abstract void ReceiveEmail();



        public override string ToString()
        {
            return $"\nSMTP-сервер: {SmtpServer}\nАдрес получателя: {Receiver};\nПолный текст сообщения: {MessageText};\nОтправитель: {Sender};\n\n";
        }

    }
}