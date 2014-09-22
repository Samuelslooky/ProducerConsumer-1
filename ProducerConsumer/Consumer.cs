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
        public int Max { get; set; }

        public Consumer(BoundedBuffer buf, int howMany)
        {
            Max = howMany;
            Buffer = buf;

        }

        public void Run()
        {
            for (int i = 0; i < Max; i++)
            {
                 Buffer.Take();
              
            }  


        }

    }
}
