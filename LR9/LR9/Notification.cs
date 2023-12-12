using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR9
{
    public class Notification : IComparable<Notification>
    {
        public string Message { get; set; }

        public Notification(string message)
        {
            this.Message = message;
        }

        public int CompareTo(Notification? other)
        {
            return this.Message.CompareTo(other?.Message);
        }



        public override string ToString()
        {
            return this.Message;
        }

        public override bool Equals(object? obj)
        {
            return obj is Notification notification &&
                   Message == notification.Message;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Message);
        }
    }
}
