using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Prac.DataStructure.LinkedList
{
    class _node<T>
    {
        public T value;
        public _node<T> next;

        public _node()
        {
            next = null;
        }
    }
    public class eList<T>
    {
        _node<T> _head;
        _node<T> idx;
        eList()
        {
            _head = null;
            idx = null;
        }

        public void Add(T t)
        {
            _node<T> curr = new _node<T>();
            if(_head == null)
            {
                _head = curr;
            }
            else
            {
                while(idx != null)
                {

                }
            }
        }

        public int getAt(int idx)
        {
            return -1;
        }

        public bool removeAt(int idx)
        {
            return true;
        }

    }

}