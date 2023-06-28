using DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.LinkedLists
{
    public static class DeleteMiddleNode
    {
        public static void Solve(ListNode<int> node)
        {
            if (node.Next is not null)
            {
                node.Value = node.Next.Value;
                node.Next = node.Next.Next;
            }
        }
        public static void TestDeleteMiddleNode()
        {
            ListNode<int> nextNode = null;
            ListNode<int> node = null;
            ListNode<int> aMiddleNode = null;
            for (var i = 10; i > 0; i--)
            {
                node = new ListNode<int>() { Value = i, Next = nextNode };
                if (i == 6)
                {
                    aMiddleNode = node;
                }
                nextNode = node;
            }
            Console.WriteLine("Before Middle Node Removal");
            node.PrintList();
            Console.WriteLine("After Middle Node Removal");
            Solve(aMiddleNode);
            node.PrintList();
        }
    }
}
