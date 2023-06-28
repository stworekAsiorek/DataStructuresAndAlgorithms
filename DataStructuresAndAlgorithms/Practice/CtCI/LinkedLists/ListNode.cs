using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.LinkedLists
{
    public class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }

        public void PrintList()
        {
            Console.WriteLine("Printing Linked List:");
            var node = this;
            while (node is not null)
            {
                Console.WriteLine($"{node.Value}");
                node = node.Next;
            }
        }
    }
}
