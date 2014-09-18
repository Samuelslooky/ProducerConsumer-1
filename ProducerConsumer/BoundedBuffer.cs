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
        private Queue<int> Buffer { get; set; }

        public BoundedBuffer(int capacity)
        {
            Capacity = capacity;
            Capacity = -1;
        }

        public Boolean IsFull()
        {
            if (Capacity == 100)
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
            Capacity = Capacity + 1;
        }

        public int Take()
        {
            int takenNumber = Buffer.Dequeue();
            return takenNumber;
        }

    }
}
