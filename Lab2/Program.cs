using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2to5
{
    class Program
    {
        // Мето, возвращающий элементы, которые <= 0
        public static IEnumerable<int> LessOrEqualZero(MyDeque<int> obj)
        {
            foreach (int i in obj)
                if (i <= 0)
                    yield return i;
        }
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
            deq.EnqueueLast(-1);

            
            bool check = deq.Contains(5);
            var head = deq.PeekFirst();
            var tail = deq.PeekLast();

            Console.WriteLine("Deque to string:");
            
            Console.WriteLine(deq.ToString());

            Console.WriteLine("Элементы, которые <= 0:");
            foreach (int i in LessOrEqualZero(deq))
                Console.WriteLine(i);

            Console.WriteLine("Перебор элементов через foreach");
            foreach (int i in deq)
                Console.WriteLine(i);


            ArrayList deqs = new ArrayList();

            MyDeque<int> deq2 = new MyDeque<int>();
            deq2.EnqueueFirst(1);
            deq2.EnqueueFirst(1);

            MyDeque<int> deq3 = new MyDeque<int>();
            deq3.EnqueueFirst(1);
            deq3.EnqueueFirst(1);
            deq3.EnqueueFirst(1);
            deq3.EnqueueFirst(1);

            deqs.Add(deq);
            deqs.Add(deq2);
            deqs.Add(deq3);
            
            deqs.Sort();

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
