using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    //класс репозитория всех млекопитающих
    public class MammalsRepository
    {
        //список всех млекопитающих
        //при том под Mammal мы можем подразумевать любой объект как класса Mammal так и любого другого наследника этого класса 
        List<Mammal> mammals = new List<Mammal>();
        
        //метод добавления нового млекопитающего в список всех 
        public void Add(Mammal mammal)
        {
            mammals.Add(mammal);
        }

        //метод который возвращает массив из количеств сколько объектов каждого класса у нас записано в списке 
        public int[] Counts()
        {
            int cnt0 = 0;
            int cnt1 = 0;
            int cnt2 = 0;
            foreach(Mammal m in mammals)
            {
                if (m.GetType() == typeof(Mammal))
                {
                    cnt0++;
                }
                else if(m.GetType() == typeof(Cat))
                {
                    cnt1++;
                }
                else if(m.GetType() == typeof(Dog)) 
                {
                    cnt2++;
                }
            }
            return new int[] {cnt0,  cnt1, cnt2 };
        }
    }
}
