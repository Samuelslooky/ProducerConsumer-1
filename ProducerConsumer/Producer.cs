using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer_øvelse
{
    public class Producer
    {
        public int Max { get; set; }
        public BoundedBuffer Buffer { get; set; }

        public Producer(BoundedBuffer buf, int capacity)
        {
            Max = capacity;
            Buffer = buf;

        }

        public void Run()
        {
            Random rnd = new Random();
            for (int i = 0; i < Max; i++)
            {
                bool isfull = Buffer.IsFull();
                if (isfull == false)
                {
                    int element = rnd.Next(1, 100);
                    Buffer.Put(element);
                }
            }       
            
        }

        
    }
}
