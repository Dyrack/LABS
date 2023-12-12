using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LR9
{
    public class EmailMessenger : IMessenger<EmailNotification>
    {
        public EmailNotification WriteMessage(string text, string n)
        {
            return new EmailNotification($"Email: {text}", );
        }
    }
}
