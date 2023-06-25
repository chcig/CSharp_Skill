using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Prac.DataStructure.LinkedList
{
    public class _node<T>
    {
        public T tvalue;
        public _node<T> next;

        public _node()
        {
            next = null;
        }
    }

    public class eList<T>
    {
        private _node<T> _head;
        private _node<T> _iter;

        public int count { get; set; }

        public eList()
        {
            _head = null;
            _iter = _head;
        }

        public void Add(T t)
        {
            _node<T> curr = new _node<T>();
            if(_head == null)
            {
                curr.tvalue = t;
                _head = curr;
                _iter = _head;
            }
            else
            {
                int cnt = 1;
                while(_iter.next != null)
                {
                    _iter = _iter.next;
                    cnt++;
                }

                curr.tvalue = t;
                _iter.next = curr;
            }
            _iter = _head;
            count++;
        }

        public void removeAt(int idx)
        {
            int idxCount = 0;
            _node<T> prenode = _iter;
            if (idx > 0)
            {
                while (_iter != null)
                {
                    if (idx == idxCount++)
                        break;
                    prenode = _iter;
                    _iter = _iter.next;
                  }

                if (_iter == null)
                    return;

                prenode.next = _iter.next;
                count--;
            }
            _iter = _head;
            return;
        }

        public T getAt(int idx)
        {
            int idxCounting = 0;
            while (_iter != null)
            {
                if (idx == idxCounting++)
                {
                    Console.WriteLine($"Get[{idx}] : {_iter.tvalue}");
                    _iter = _head;
                    return _iter.tvalue;
                }
                _iter = _iter.next;
            }
            _iter = _head;
            return default(T);
        }

        public void Display()
        {
            int Curridx = 0;
            while(_iter != null)
            {
                Console.WriteLine($"[{Curridx++}] : {_iter.tvalue}");
                _iter = _iter.next;
            }
        }

    }

}