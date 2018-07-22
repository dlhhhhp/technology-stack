using System;
using System.Collections.Generic;
using System.Text;

namespace a0101_Queue
{
    /// <summary>
    /// 基于环形数组实现的队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueFixedLengthArray<T>
    {
        private T[] _array;
        private int _head;
        private int _tail;
        private int _size;

        public QueueFixedLengthArray(int size = 5)
        {
            if (size < 2)
            {
                Console.WriteLine("队列长度太小，最小要求队列长度为2");
                return;
            }
            _size = size + 1;
            _array = new T[_size];
            _head = 1;
            _tail = 1;
        }

        public int Count
        {
            get { return _size; }
        }

        public void Enqueue(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("队列已满，不能入队");
                return;
            }
            _array[_tail] = item;

            _tail = (_tail + 1) % _size;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("队列已空，不能出队");
                return;
            }
            _array[_head] = default(T);

            _head = (_head + 1) % _size;
        }


        public bool IsFull()
        {
            return (_tail + 1) % _size == _head;
        }

        public bool IsEmpty()
        {
            return _head == _tail;
        }
        
        public string PrintQueue()
        {
            StringBuilder build = new StringBuilder("");
            foreach (var item in _array)
            {
                if (item != null)
                    build.Append(item.ToString() + ",");
                else
                    build.Append("null" + ",");
            }
            string result = build.ToString();
            result = result.Remove(result.LastIndexOf(","), ",".Length);
            return $"队首索引[{_head}]，队尾索引[{_tail}]，队列信息[{result}]";
        }

    }
}
