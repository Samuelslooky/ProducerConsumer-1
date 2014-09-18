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
        public Queue<int> Buffer { get; set; }

        public BoundedBuffer(int capacity, Queue<int> buffer)
        {
            Capacity = capacity;
            Buffer = buffer;
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
        }

        public int Take()
        {
            Buffer.Dequeue();
        }

    }
}
