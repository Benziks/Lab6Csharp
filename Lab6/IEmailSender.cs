using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public interface IEmailSender
    {
        void SendEmail(string recipient, string message);
        void ReceiveEmail();
    }
}