using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDeque<int> deq = new MyDeque<int>();
            deq.EnqueueFirst(1);
            deq.EnqueueFirst(2);
            deq.EnqueueFirst(3);
            deq.EnqueueFirst(4);
            deq.EnqueueFirst(5);
            deq.EnqueueLast(6);
            deq.EnqueueLast(7);
            deq.EnqueueLast(8);
            deq.EnqueueLast(9);
            deq.EnqueueLast(10);

            bool check = deq.Contains(5);
            var head = deq.PeekFirst();
            var tail = deq.PeekLast();

            //deq.Clear();

            deq.DequeueFirst();
            deq.DequeueFirst();
            deq.DequeueFirst();
            deq.DequeueFirst();
            deq.DequeueFirst();
            deq.DequeueLast();
            deq.DequeueLast();
            deq.DequeueLast();
            deq.DequeueLast();
            deq.DequeueLast();

            Console.Read();
        }
    }
}
