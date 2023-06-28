using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.StacksAndQueues
{
    public class QueueViaStacks<T>
    {
        private Stack<T> _stack = new Stack<T>();
        private Stack<T> _tempStack = new Stack<T>();

        public void Enqueue(T item)
        {
            _stack.Push(item);
        }

        public T Dequeue()
        {
            ShiftStacks();
            return _tempStack.Pop();

        }
        private void ShiftStacks()
        {
            if (_tempStack.IsEmpty())
            {
                while (!_stack.IsEmpty())
                {
                    _tempStack.Push(_stack.Pop());
                }
            }
        }
    }
}
