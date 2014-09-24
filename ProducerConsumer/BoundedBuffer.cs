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
            this.Buffer = new Queue<int>();
            
        }

        public Boolean IsFull()
        {
            if (this.Buffer.Count < this.Capacity)
            {
                return false;
            }

            return true;
            
        }

        public void Put(int element)
        {
            lock (this.Buffer)
            {
                while (this.IsFull())
                {
                    Monitor.Wait(this.Buffer);
                }

                    this.Buffer.Enqueue(element);
                    Console.WriteLine("Consumer just put {0} into the buffer", element);
                    Monitor.PulseAll(this.Buffer);
                
            }
            
            
        }

        public int Take()
        {
            lock (this.Buffer)
            {
                while (this.Buffer.Count == 0)
                {
                    Monitor.Wait(this.Buffer);
                }
            
                int takenNumber = this.Buffer.Dequeue();
                Console.WriteLine("The number: {0} has been consumed from thread {1}", takenNumber, Thread.CurrentThread.ManagedThreadId);
                Monitor.PulseAll(this.Buffer);
                return takenNumber; 
            }
            
        }

    }
}
