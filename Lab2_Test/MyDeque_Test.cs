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

        #region Тест добавления в начало дека
        [Test]
        public void Test_EndeqFirst()
        {

        }
        #endregion

        [Test]
        public void Test_Bad_EndeqFirst()
        {

        }
    }
}
