using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR9
{
    //ковариантный интерфейс 
    public interface IMessenger<out T>
    {
        T WriteMessage(string text, string n);
    }
}
