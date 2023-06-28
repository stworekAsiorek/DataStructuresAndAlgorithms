using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.StacksAndQueues
{
    public class StackMin
    {
        private class Node
        {
            public int Value { get; init; }
            public int Min { get; init; }
            public Node Next { get; set; }
        }

        private Node top = null;

        public void Push(int value)
        {
            int min = top is null || top.Min > value ? value : top.Min;
            var newNode = new Node() { Value = value, Min = min };
            newNode.Next = top;
            top = newNode;
        }
        public int? Pop()
        {
            if (top is null)
            {
                return null;
            }
            var value = top.Value;
            top = top.Next;
            return value;
        }

        public int? Min()
        {
            if (top is null)
            {
                return null;
            }
            return top.Min;
        }

    }
}
