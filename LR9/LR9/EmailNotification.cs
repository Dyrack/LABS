using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR9
{
    //класс наследник для имаил нотификаций с его собственными свойства и переопределние основных методов 
    public class EmailNotification : Notification
    {
        private string Email { get; set; }
        public EmailNotification(string message, string email) : base(message)
        {
            this.Email = email;
        }



        public override string ToString()
        {
            return base.ToString() + ", " + this.Email;
        }

        public override bool Equals(object? obj)
        {
            return obj is EmailNotification notification &&
                   base.Equals(obj) &&
                   Email == notification.Email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Email);
        }
    }
}
