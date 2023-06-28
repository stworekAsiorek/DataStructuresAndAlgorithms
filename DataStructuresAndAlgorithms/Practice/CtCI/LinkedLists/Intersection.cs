namespace DataStructuresAndAlgorithms.Practice.CtCI.LinkedLists
{
    internal class Intersection
    {
        public static Tuple<bool, ListNode<int>> Solve(ListNode<int> n1, ListNode<int> n2)
        {
            var tuple1 = GetLengthAndLastNode(n1);
            var tuple2 = GetLengthAndLastNode(n2);
            if (!ReferenceEquals(tuple1.Item1, tuple2.Item1))
            {
                return new Tuple<bool, ListNode<int>>(false, null);
            }
            var pointer1 = n1;
            var pointer2 = n2;
            if (tuple1.Item2 > tuple2.Item2)
            {
                pointer1 = MovePointer(n1, tuple1.Item2 - tuple2.Item2);
            }
            else if (tuple2.Item2 > tuple1.Item2)
            {
                pointer2 = MovePointer(n2, tuple2.Item2 - tuple1.Item2);
            }
            while (!ReferenceEquals(pointer1, pointer2) && pointer1 is not null && pointer2 is not null)
            {
                pointer1 = pointer1.Next;
                pointer2 = pointer2.Next;
            }

            return new Tuple<bool, ListNode<int>>(true, pointer1);
        }

        public static ListNode<int> MovePointer(ListNode<int> n, int k)
        {
            for (var i = 0; i < k && n.Next is not null; i++)
            {
                n = n.Next;
            }
            return n;
        }

        public static Tuple<ListNode<int>, int> GetLengthAndLastNode(ListNode<int> n)
        {
            var length = 0;
            while (n.Next is not null)
            {
                n = n.Next;
                length += 1;
            }
            return new Tuple<ListNode<int>, int>(n, length);
        }

        public static void TestIntersection()
        {
            ListNode<int> n5 = new ListNode<int>() { Value = 1 };
            ListNode<int> n4 = new ListNode<int>() { Value = 2, Next = n5 };
            ListNode<int> n3 = new ListNode<int>() { Value = 3, Next = n4 };
            ListNode<int> n3half = new ListNode<int>() { Value = 4, Next = n3 };
            ListNode<int> n2 = new ListNode<int>() { Value = 5, Next = n3half };
            ListNode<int> n1 = new ListNode<int>() { Value = 6, Next = n2 };

            ListNode<int> n14 = new ListNode<int> { Value = 4, Next = n3 };
            ListNode<int> n13 = new ListNode<int> { Value = 5, Next = n14 };
            ListNode<int> n12 = new ListNode<int> { Value = 7, Next = n13 };
            ListNode<int> n11 = new ListNode<int> { Value = 8, Next = n12 };
            n1.PrintList();
            n11.PrintList();
            var result = Solve(n1, n11);
            Console.WriteLine($"Are Intersecting?: {result.Item1} Which ListNode<int>?: {result.Item2.Value}");
        }
    }
}
