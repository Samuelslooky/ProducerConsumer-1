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

        public Consumer(BoundedBuffer buf)
        {
            Buffer = buf;

        }

        public void Run()
        {
            int temp;

            do
            {
                temp = this.Buffer.Take();
            } while (temp != -1);
        }

    }
}
