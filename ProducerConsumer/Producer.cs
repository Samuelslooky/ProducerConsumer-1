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

        public Producer(BoundedBuffer buf, int howMany)
        {
            Max = howMany;
            Buffer = buf;

        }

        public void Run()
        {
            for (int i = 0; i < this.Max; i++)
            {
                this.Buffer.Put(i);
               
            }
            
            this.Buffer.Put(-1);

            //Random rnd = new Random();
            //for (int i = 0; i < Max; i++)
            //{
            //    bool isfull = Buffer.IsFull();
            //    if (isfull == false)
            //    {
            //        int element = rnd.Next(1, 100);
            //        Buffer.Put(element);
            //        Console.WriteLine("Producer just put {0} into the buffer", element);
            //    }
            //}       
            
        }

        
    }
}
