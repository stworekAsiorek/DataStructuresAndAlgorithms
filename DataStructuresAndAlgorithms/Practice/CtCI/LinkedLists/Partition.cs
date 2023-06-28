namespace DataStructuresAndAlgorithms.Practice.CtCI.LinkedLists
{
    public static class Partition 
    {
        public static ListNode<int> Solve(ListNode<int> head, int pivot)
        {
            ListNode<int> leftPartition = null;
            ListNode<int> rightPartition = null;
            var node = head;
            while (node is not null)
            {
                var temp = node;
                node = node.Next;
                if (temp.Value < pivot)
                {
                    temp.Next = leftPartition;
                    leftPartition = temp;
                }
                else
                {
                    temp.Next = rightPartition;
                    rightPartition = temp;
                }
            }
            if (rightPartition is null || leftPartition is null)
            {
                return head;
            }

            node = leftPartition;
            while (node.Next is not null)
            {
                node = node.Next;
            }
            node.Next = rightPartition;
            leftPartition.PrintList();
            return leftPartition;
        }

        public static void TestPartition()
        {
            var valueList = new int[] { 3, 5, 8, 5, 10, 2, 1 };
            Array.Reverse(valueList);
            Console.WriteLine($"Value list: {string.Join(", ", valueList)}");
            ListNode<int> nextNode = null;
            ListNode<int> node = null;
            foreach (var i in valueList)
            {
                node = new ListNode<int>() { Value = i, Next = nextNode };
                nextNode = node;
            }
            Console.WriteLine("Before Partitioning");
            node.PrintList();
            Console.WriteLine("After Partioning");
            var list = Solve(node, 5);
            list.PrintList();
        }
    }
    
}
