using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer_øvelse
{
    public class Consumer
    {
        public BoundedBuffer Buffer { get; set; }

        public Consumer(BoundedBuffer buf)
        {
            Buffer = buf;

        }

        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                int takenNumber = Buffer.Take();
                Console.WriteLine("The number: " + takenNumber + "has been consumed");

            }  


        }

    }
}
