using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR9
{
    //класс наследник для смс нотификаций с его собственными свойства и переопределние основных методов 
    public class SMSNotification : Notification
    {
        string PhoneNumber { get; set; }

        public SMSNotification(string message, string phoneNumber) : base(message) 
        {
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + this.PhoneNumber;
        }

        public override bool Equals(object? obj)
        {
            return obj is SMSNotification notification &&
                   base.Equals(obj) &&
                   PhoneNumber == notification.PhoneNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), PhoneNumber);
        }
    }
}
