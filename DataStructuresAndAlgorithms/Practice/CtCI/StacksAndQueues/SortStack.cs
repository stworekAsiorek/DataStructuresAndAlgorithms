using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.StacksAndQueues
{
    //Solution not compliant with the one provided by book
    public class SortStack
    {
        private Stack<int> _stack = new Stack<int>();
        private Stack<int> _tempStack = new Stack<int>();

        public void Push(int item)
        {
            if (!_stack.IsEmpty() && _stack.Peek() < item)
            {
                var count = 0;
                while (!_tempStack.IsEmpty() || _tempStack.Peek() < item)
                {
                    _stack.Push(_tempStack.Pop());
                    count += 1;
                }
                _tempStack.Push(item);
                for (int i = 0; i < count; i++)
                {
                    _tempStack.Push(_stack.Pop());
                }
                return;
            }
            _stack.Push(item);
        }
        public int Pop()
        {
            ShiftStacks();
            return _stack.Pop();
        }

        public int Peek()
        {
            ShiftStacks();
            return _stack.Peek();
        }

        public bool IsEmpty()
        {
            return _stack.IsEmpty() && _tempStack.IsEmpty();
        }

        private void ShiftStacks()
        {
            if (_stack.IsEmpty())
            {
                while (!_tempStack.IsEmpty())
                {
                    _stack.Push(_tempStack.Pop());
                }
            }
        }
    }
}
