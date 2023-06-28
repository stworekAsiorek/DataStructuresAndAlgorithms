using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.LinkedLists
{
    public static class ReturnKthToLast
    {

        //KTH TO LAST
        public static int? Solve(ListNode<int> head, int k)
        {
            var pointer1 = head;
            var pointer2 = head;
            for (var i = 0; i < k; i++)
            {
                if (pointer1 is null)
                {
                    return null;
                }
                pointer1 = pointer1.Next;
            }
            while (pointer1 is not null)
            {
                pointer1 = pointer1.Next;
                pointer2 = pointer2.Next;
            }
            return pointer2.Value;
        }

        public static void Test()
        {
            ListNode<int> nextListNode = null;
            ListNode<int> node = null;
            for (var i = 10; i > 0; i--)
            {
                node = new ListNode<int>() { Value = i, Next = nextListNode };
                nextListNode = node;
            }
            node.PrintList();
            Console.WriteLine($"Kth to last element : {Solve(node, 4)}");
        }
    }
}
