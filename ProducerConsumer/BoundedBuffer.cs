using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer_øvelse
{
    public class BoundedBuffer 
    {
        public int Capacity { get; set; }
        public int HowMany { get; set; }
        private Queue<int> Buffer { get; set; }

        public BoundedBuffer(int capacity, int howMany)
        {
            Capacity = capacity;
            HowMany = howMany;
            Capacity = -1;
        }

        public Boolean IsFull()
        {
            if (HowMany == Capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Put(int element)
        {
            Buffer.Enqueue(element);
            HowMany = HowMany + 1;
        }

        public int Take()
        {
            int takenNumber = Buffer.Dequeue();
            HowMany = HowMany - 1;
            return takenNumber;

        }

    }
}
