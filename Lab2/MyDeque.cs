using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class MyDeque<T> : IMyDeque<T>, IEnumerable, ICloneable
    {
        T[] items;
        int count;
        int head;
        int tail;

        // Конструктор, задаёт начальный размер массива для дека
        public MyDeque()
        {
            items = new T[100];
        }

        // Длина дека
        public int Count
        {
            get { return count; }
        }

        // Свойство. Проверка на пустоту
        public bool IsEmpty
        {
            get { return count == 0; }
        }

        // Проверка на то, есть ли такой item в деке
        public bool Contains(T item)
        {
            for ( var i = head; i <= tail; i++ )
            {
                if (items[i].Equals(item))
                    return true;
            }
            return false;
        }

        // Удаление элемента с начала
        public T DequeueFirst()
        {
            if (IsEmpty)
                throw new Exception("Дек пуст, удалять нечего");
            else
            {
                T item = items[head];
                --count;
                items[head] = default(T);
                ++head;
                return item;
            }
        }

        // Удаление элемента с конца
        public T DequeueLast()
        {
            if (IsEmpty)
                throw new Exception("Дек пуст, удалять нечего");
            else
            {
                T item = items[tail];
                --count;
                items[tail] = default(T);
                --tail;
                return item;
            }
        }

        // Добавление элемента в начало
        public void EnqueueFirst(T item)
        {
            if (IsEmpty)
            {
                head = 30;
                tail = head;
                items[head] = item;
                count++;
            }
            else
            {
                if (--head < 0)
                    Resize(10);
                //--head;
                items[head] = item;
                count++;
            }
        }

        // Добавление элемента в конец
        public void EnqueueLast(T item)
        {
            if (IsEmpty)
            {
                head = 30;
                tail = head;
                items[head] = item;
                count++;
            }
            else
            {
                if (++tail == items.Length)
                    Resize(10);
                //++tail;
                items[tail] = item;
                count++;
            }
        }

        // Узнать какой элемент в начале дека
        public T PeekFirst()
        {
            if (IsEmpty)
                throw new Exception("Дек пуст");
            return items[head];
        }

        // Узнать какой элемент в конце дека
        public T PeekLast()
        {
            if (IsEmpty)
                throw new Exception("Дек пуст");
            return items[tail];
        }

        // Метод увеличения размера дека
        void Resize(int max)
        {
            T[] tempItems = new T[items.Length + max];
            int len = max / 2;
            int len2 = len + count;
            for (var i = len; i < len2; i++)
            {
                tempItems[i] = items[i - len];
            }
            items = tempItems;
        }

        // Очистка дека, возвращение к первоначальному состоянию
        public void Clear()
        {
            if (IsEmpty)
                throw new Exception("Дек пуст, его не за чем чистить");
            else
            {
                for (var i = head; i <= tail; i++)
                    items[i] = default(T);
                count = 0;
                T[] tempItems = new T[0];
                items = tempItems;
            }
        }

        // Реализация интерфейса IEnumerable в котором единственный метод GetEnumerator()
        public IEnumerator GetEnumerator()
        {
            for (int i = head; i <= tail; i++)
                yield return items[i];
        }

        // Реализация интерфейса ICloneable в котором единственный метод Clone()
        // Неглубокого копирования будет достаточно
        // потому что в деке нет свойств непримитивных типов
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
