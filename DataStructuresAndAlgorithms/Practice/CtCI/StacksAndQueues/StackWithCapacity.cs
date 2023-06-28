using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.StacksAndQueues
{
    public class StackWithCapacity<T> : Stack<T>
    {
        private readonly int _capacity;
        private int _count = 0;
        public StackWithCapacity(int capacity) : base()
        {
            _capacity = capacity;
        }

        public override T Pop()
        {
            _count = _count > 0 ? _count - 1 : 0;
            return base.Pop();
        }

        public override void Push(T item)
        {
            if (_count < _capacity)
            {
                base.Push(item);
                _count = _count + 1;
                return;
            }
            throw new FullStackException();
        }

        public bool TryPush(T item)
        {
            if (_count < _capacity)
            {
                base.Push(item);
                _count = _count + 1;
                return true;
            }
            return false;
        }
    }

    public class FullStackException : Exception
    {
    }
}
