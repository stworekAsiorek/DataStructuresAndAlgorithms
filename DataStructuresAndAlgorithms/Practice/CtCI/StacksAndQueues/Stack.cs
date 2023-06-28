using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.StacksAndQueues
{
    public class Stack<T>
    {
        private class StackNode<Type>
        {
            public Type Data { get; set; }
            public StackNode<Type> Next { get; set; }
        }

        private StackNode<T> top;

        public virtual T Pop()
        {
            if (top is null)
            {
                throw new EmptyStackException();
            }
            T item = top.Data;
            top = top.Next;
            return item;
        }

        public virtual void Push(T item)
        {
            var stackNode = new StackNode<T>
            {
                Data = item,
                Next = top
            };
            top = stackNode;
        }

        public T Peek()
        {
            if (top is null)
            {
                throw new EmptyStackException();
            }
            return top.Data;
        }

        public bool IsEmpty()
        {
            return top is null;
        }
    }

    public class EmptyStackException : Exception
    {
    }
}
