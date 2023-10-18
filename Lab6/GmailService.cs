using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class GmailService : EmailService
    {
        private bool _hasAttachments = false;
        private bool _spam = false;
        private bool _isStarred = false;

        public GmailService(bool hasAttachments, bool spam, bool isStarred, string smtpServer, string receiver, string messageText, string sender) : base(smtpServer, receiver, messageText, sender)
        {
            HasAttachments = hasAttachments;
            Spam = spam;
            IsStarred = isStarred;
        }

        public bool HasAttachments
        {
            get => _hasAttachments;
            set => _hasAttachments = value;
        }
        public bool Spam
        {
            get => _spam;
            set => _spam = value;
        }

        public bool IsStarred
        {
            get => _isStarred;
            set => _isStarred = value;
        }




        public override string ToString()
        {
            return "Email:\n" + $"\nНаличие вложенных файлов: {HasAttachments}\nОтметка спама: {Spam};\nПометка звездой(важное): {IsStarred};" + base.ToString();
        }
    }
}