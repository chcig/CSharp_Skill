using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Prac.DataStructure.Que
{
    public class node<T>
    {
        public node<T> next = null;
        public T tvalue = default(T);
    }
    /// <summary>
    /// First In First Out [PIPO]
    /// </summary>
    public class eQue<T>
    {
        private node<T> _head = null;
        private node<T> _iter;

        public int count { get; set; }

        public eQue()
        {
            _iter = _head;
        }

        public void Enqueue(T t)
        {
            node<T> addnode = new node<T>();
            addnode.tvalue = t;

            if(_head == null)
                _head = addnode;
            else
            {
                while (_iter.next != null)
                    _iter = _iter.next;
                _iter.next = addnode;
            }
            count++;
            Console.WriteLine($"[Queue] Enqueue : {t}");
            _iter = _head;
        }

        public T Dequeue()
        {
            if (_head == null)
            {
                Console.WriteLine($"[Queue] Head is null");
                return default(T);
            }

            T temp = _head.tvalue;
            _head = _head.next;
            _iter = _head;
            //while (_iter.next != null)
            //    _iter = _iter.next;

            count--;
            Console.WriteLine($"[Queue] Dequeue : {temp}");
            return temp;
        }

        public void display()
        {
            int count = 0;
            while (_iter != null)
            {
                Console.WriteLine($"[{count++}] : {_iter.tvalue}");
                _iter = _iter.next;
            }
        }
    }

}
