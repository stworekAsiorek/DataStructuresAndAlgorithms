using DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.LinkedLists
{
    public  class SumLists
    {
        public static ListNode<int> Solve(ListNode<int> n1, ListNode<int> n2)
        {
            return SumListsRecursive(n1, n2, false);
        }

        public static ListNode<int> SumListsRecursive(ListNode<int> n1, ListNode<int> n2, bool overFlow)
        {
            if (n1 is null && n2 is null && !overFlow)
            {
                return null;
            }
            var sum = GetNodeValue(n1) + GetNodeValue(n2);
            if (overFlow)
            {
                sum += 1;
            }
            overFlow = sum > 9;
            return new ListNode<int>() { Value = sum % 10, Next = SumListsRecursive(n1?.Next, n2?.Next, overFlow) };
        }

        private static int GetNodeValue(ListNode<int> n)
        {
            if (n is null)
            {
                return 0;
            }
            return n.Value;
        }

        public static void TestSumLists()
        {
            ListNode<int> n13 = new ListNode<int>() { Value = 6 };
            ListNode<int> n12 = new ListNode<int>() { Value = 1, Next = n13 };
            ListNode<int> n11 = new ListNode<int>() { Value = 7, Next = n12 };
            ListNode<int> n23 = new ListNode<int>() { Value = 2 };
            ListNode<int> n22 = new ListNode<int>() { Value = 9, Next = n23 };
            ListNode<int> n21 = new ListNode<int>() { Value = 5, Next = n22 };
            Console.WriteLine("List 1: ");
            n11.PrintList();
            Console.WriteLine("List 2: ");
            n21.PrintList();

            var sumListsResult = Solve(n11, n21);
            Console.WriteLine("Result: ");
            sumListsResult.PrintList();
        }

        //SUM LISTS
        public static ListNode<int> SolveForward(ListNode<int> n1, ListNode<int> n2)
        {
            var n1Length = GetListLength(n1);
            var n2Length = GetListLength(n2);
            if (n1Length < n2Length)
            {
                n1 = AddProceedingZeros(n1, n2Length - n1Length);
            }
            else if (n2Length < n1Length)
            {
                n2 = AddProceedingZeros(n2, n1Length - n2Length);
            }
            var result = SumListsForwardR(n1, n2);
            if (result.Item2)
            {
                return new ListNode<int>() { Value = 1, Next = result.Item1 };
            }
            return result.Item1;
        }

        private static ListNode<int> AddProceedingZeros(ListNode<int> n1, int numberOfZeros)
        {
            var node = n1;
            for (var i = 0; i < numberOfZeros; i++)
            {
                var newNode = new ListNode<int>() { Value = 0, Next = node };
                node = newNode;
            }
            return node;

        }
        private static int GetListLength(ListNode<int> n)
        {
            var length = 0;
            while (n is not null)
            {
                length += 1;
                n = n.Next;
            }
            return length;
        }

        public static Tuple<ListNode<int>, bool> SumListsForwardR(ListNode<int> n1, ListNode<int> n2)
        {
            if (n1 is null && n2 is null)
            {
                return new Tuple<ListNode<int>, bool>(null, false);
            }

            var subListsResult = SumListsForwardR(n1.Next, n2.Next);
            var currentNodeSum = n1.Value + n2.Value;
            if (subListsResult.Item2)
            {
                currentNodeSum += 1;
            }
            return new Tuple<ListNode<int>, bool>(new ListNode<int>() { Value = currentNodeSum % 10, Next = subListsResult.Item1 }, currentNodeSum > 9);
        }

        public static void TestSumListsR()
        {
            ListNode<int> n13 = new ListNode<int>() { Value = 7 };
            ListNode<int> n12 = new ListNode<int>() { Value = 1, Next = n13 };
            ListNode<int> n11 = new ListNode<int>() { Value = 6, Next = n12 };
            ListNode<int> n23 = new ListNode<int>() { Value = 5 };
            ListNode<int> n22 = new ListNode<int>() { Value = 9, Next = n23 };
            ListNode<int> n21 = new ListNode<int>() { Value = 2, Next = n22 };
            Console.WriteLine("List 1: ");
            n11.PrintList();
            Console.WriteLine("List 2: ");
            n21.PrintList();

            var sumListsResult = SolveForward(n11, n21);
            Console.WriteLine("Result: ");
            sumListsResult.PrintList();
        }
    }
}
