using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /// <summary>
    /// Класс GmailService, который наследуется от EmailService
    /// </summary>
    public class GmailService : EmailService
    {
        private bool _hasAttachments = false;
        private bool _spam = false;
        private bool _isStarred = false;


        /// <summary>
        /// Свойство HasAttachments(Пометка наличия вложенных файлов) 
        /// </summary>
        public bool HasAttachments
        {
            get => _hasAttachments;
            set => _hasAttachments = value;
        }

        /// <summary>
        /// Свойство Spam(Пометка спама) 
        /// </summary>
        public bool Spam
        {
            get => _spam;
            set => _spam = value;
        }

        /// <summary>
        /// Свойство IsStarred(Пометка важных сообщений) 
        /// </summary>
        public bool IsStarred
        {
            get => _isStarred;
            set => _isStarred = value;
        }

        /// <summary>
        /// Создает новый экземпляр класса GmailService и наследует свойства EmailService.
        /// </summary>
        /// <param name="hasAttachments">Пометка наличия вложенных файлов</param>
        /// <param name="spam">Пометка спама</param>
        /// <param name="isStarred">Пометка важных сообщений</param>
        /// <param name="smtpServer">SMTP-сервер</param>
        /// <param name="receiver">Получатель</param>
        /// <param name="messageText">Текст письма</param>
        /// <param name="sender">Отправитель</param>
        public GmailService(bool hasAttachments, bool spam, bool isStarred, string smtpServer, string receiver, string messageText, string sender) : base(smtpServer, receiver, messageText, sender)
        {
            HasAttachments = hasAttachments;
            Spam = spam;
            IsStarred = isStarred;
        }


        public override string ToString()
        {
            return "Email:\n" + $"\nНаличие вложенных файлов: {HasAttachments}\nОтметка спама: {Spam};\nПометка звездой(важное): {IsStarred};" + base.ToString();
        }
    }
}