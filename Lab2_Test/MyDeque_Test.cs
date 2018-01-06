using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Lab2;

namespace Lab2_Test
{
    [TestFixture]
    class MyDeque_Test
    {
        #region Тест конструктора
        [Test]
        public void Test_of_constructor()
        {
            MyDeque<int> deq = new MyDeque<int>();
            int expected = 0;
            int actual = deq.Count;
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Тест свойства длины дека
        [Test]
        public void Test_Count()
        {
            MyDeque<int> deq = new MyDeque<int>();
            deq.EnqueueFirst(1);
            deq.EnqueueFirst(2);
            deq.EnqueueFirst(3);
            deq.EnqueueFirst(4);
            Assert.AreEqual(deq.Count, 4);

            deq.Clear();
            Assert.AreEqual(deq.Count, 0);
        }
        #endregion

        #region Тест добавления элемента в начало дека
        [Test]
        public void Test_EndqueueFirst()
        {
            MyDeque<string> deq = new MyDeque<string>();
            deq.EnqueueFirst("Первый");
            deq.EnqueueFirst("Второй");
            deq.EnqueueFirst("Третий");
            Assert.AreEqual(deq.Count, 3);
            Assert.AreNotEqual(deq.PeekFirst(), deq.PeekLast());
        }
        #endregion

        #region Тест добавления элемента в конец дека
        [Test]
        public void Test_EnqueueLast()
        {
            MyDeque<int> deq = new MyDeque<int>();
            deq.EnqueueLast(1);
            deq.EnqueueLast(2);
            deq.EnqueueLast(3);
            deq.EnqueueLast(4);
            Assert.AreEqual(deq.Count, 4);
            Assert.AreNotEqual(deq.PeekFirst(), deq.PeekLast());
        }
        #endregion
        
        #region Тест получения элемента из начала очереди
        [Test]
        public void Test_PeekFirst()
        {
            MyDeque<int> deq = new MyDeque<int>();
            deq.EnqueueLast(1);
            deq.EnqueueLast(2);
            deq.EnqueueLast(3);
            deq.EnqueueLast(4);
            Assert.AreEqual(deq.PeekFirst(), 1);
        }
        #endregion
        
        #region Тест получения элемента из конца очереди
        [Test]
        public void Test_PeekLast()
        {
            MyDeque<int> deq = new MyDeque<int>();
            deq.EnqueueLast(1);
            deq.EnqueueLast(2);
            deq.EnqueueLast(3);
            deq.EnqueueLast(4);
            Assert.AreEqual(deq.PeekLast(), 4);
        }
        #endregion
        
        #region Тест удаления элемента из начала очереди
        [Test]
        public void Test_DequeueFirst()
        {
            MyDeque<int> deq = new MyDeque<int>();
            deq.EnqueueLast(1);
            deq.EnqueueLast(2);
            deq.EnqueueLast(3);
            deq.EnqueueLast(4);
            int expected = deq.PeekFirst();
            int count1 = deq.Count;
            int actual = deq.DequeueFirst();
            int count2 = deq.Count;
            Assert.AreEqual(actual, expected);
            Assert.AreNotEqual(count1, count2);
        }
        #endregion
        
        #region Тест удаления элемента из конца очереди
        [Test]
        public void Test_DequeueLast()
        {
            MyDeque<int> deq = new MyDeque<int>();
            deq.EnqueueLast(1);
            deq.EnqueueLast(2);
            deq.EnqueueLast(3);
            deq.EnqueueLast(4);
            int expected = deq.PeekLast();
            int count1 = deq.Count;
            int actual = deq.DequeueLast();
            int count2 = deq.Count;
            Assert.AreEqual(actual, expected);
            Assert.AreNotEqual(count1, count2);
        }
        #endregion
        
        #region Тест проверки дека на пустоту
        [Test]
        public void Test_IsEmpty()
        {
            MyDeque<int> deq = new MyDeque<int>();
            Assert.AreEqual(deq.IsEmpty, true);

            deq.EnqueueFirst(1);
            Assert.AreEqual(deq.IsEmpty, false);
        }
        #endregion
        
        #region Тест очистки дека
        [Test]
        public void Test_Clear()
        {
            MyDeque<int> deq = new MyDeque<int>();
            deq.EnqueueFirst(1);
            deq.EnqueueFirst(2);
            deq.EnqueueFirst(3);
            deq.EnqueueFirst(4);
            Assert.AreEqual(deq.Count, 4);

            deq.Clear();
            Assert.AreEqual(deq.Count, 0);
        }
        #endregion

        #region Тест метода Contains()
        [Test]
        public void Test_Contains()
        {
            MyDeque<int> deq = new MyDeque<int>();
            deq.EnqueueFirst(1);
            deq.EnqueueFirst(2);
            deq.EnqueueFirst(3);
            deq.EnqueueFirst(4);
            Assert.AreEqual(deq.Contains(2), true);
        }
        #endregion

        #region Тест метода GetEnumerator()
        [Test]
        public void Test_GetEnumerator()
        {
            MyDeque<int> deq = new MyDeque<int>();
            deq.EnqueueLast(1);
            deq.EnqueueLast(2);
            deq.EnqueueLast(3);
            deq.EnqueueLast(4);

            int[] numbers = new int[deq.Count];

            foreach (int i in deq)
            {
                for (int n = 0; n < numbers.Length; n++)
                    numbers[n] = i;
            }

            Assert.AreEqual(deq.PeekLast(), numbers[deq.Count - 1]);
        }
        #endregion

        #region Тест клонирования
        [Test]
        public void Test_Clone()
        {
            MyDeque<int> deq1 = new MyDeque<int>();
            MyDeque<int> deq2 = new MyDeque<int>();

            deq1.EnqueueLast(1);
            deq1.EnqueueLast(2);
            deq1.EnqueueLast(3);
            deq1.EnqueueLast(4);

            deq2 = (MyDeque<int>) deq1.Clone();

            Assert.AreEqual(deq1.Count, deq2.Count);
            Assert.AreEqual(deq1.PeekLast(), deq2.PeekLast());
        }
        #endregion
    }
}
