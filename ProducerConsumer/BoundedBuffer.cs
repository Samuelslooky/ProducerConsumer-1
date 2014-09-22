using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
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
            
        }

        public Boolean IsFull()
        {
            if (Buffer.Count < this.Capacity)
            {
                return false;
            }

            return true;
            
        }

        public void Put(int element)
        {
            lock (Buffer)
            {
                if (!this.IsFull())
                {
                    Buffer.Enqueue(element);
                    Console.WriteLine("Consumer just put {0} into the buffer", element);
                    Monitor.PulseAll(Buffer);
                } 
            }
            
            
        }

        public int Take()
        {
            lock (Buffer)
            {
                while (Buffer.Count == 0)
                {
                    Monitor.Wait(Buffer);
                }
            
                int takenNumber = Buffer.Dequeue();
                Console.WriteLine("The number: {0} has been consumed", takenNumber);
                return takenNumber; 
            }
            
        }

    }
}
