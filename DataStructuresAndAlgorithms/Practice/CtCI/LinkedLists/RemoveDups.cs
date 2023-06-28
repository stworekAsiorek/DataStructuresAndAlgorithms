namespace DataStructuresAndAlgorithms.Practice.CtCI.LinkedLists
{
    public static class RemoveDups
    {
        public static void Solve(ListNode<int> head)
        {
            var hashSet = new HashSet<int>();
            var node = head;
            while (node is not null)
            {
                hashSet.Add(node.Value);
                while (node.Next is not null && hashSet.Contains(node.Next.Value))
                {
                    node.Next = node.Next.Next;
                }
                node = node.Next;
            }
        }

        public static void Test()
        {
            var n5 = new ListNode<int>() { Value = 5 };
            var n4 = new ListNode<int>() { Value = 5, Next = n5 };
            var n3 = new ListNode<int>() { Value = 5, Next = n4 };
            var n2 = new ListNode<int>() { Value = 4, Next = n3 };
            var n1 = new ListNode<int>() { Value = 4, Next = n2 };
            Console.WriteLine("Before Dups Removal");
            n1.PrintList();
            Console.WriteLine("After Dups Removal");
            Solve(n1);
            n1.PrintList();
        }
    }
}
