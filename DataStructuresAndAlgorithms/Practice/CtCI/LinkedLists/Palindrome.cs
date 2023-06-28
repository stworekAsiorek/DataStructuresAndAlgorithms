namespace DataStructuresAndAlgorithms.Practice.CtCI.LinkedLists
{
    public class Palindrome
    {
        public static bool Solve(ListNode<int> n)
        {
            if (n is null)
            {
                return false;
            }
            var pointer1 = n;
            var pointer2 = n;
            var stack = new Stack<int>();
            var isOdd = false;
            while (pointer2.Next?.Next is not null)
            {
                stack.Push(pointer1.Value);
                pointer1 = pointer1.Next;
                pointer2 = pointer2.Next?.Next;
            }

            if (pointer2.Next is null)
            {
                isOdd = true;
            }

            if (!isOdd)
            {
                stack.Push(pointer1.Value);
            }
            pointer1 = pointer1.Next;

            while (pointer1 is not null)
            {
                var expectedValue = stack.Pop();
                if (pointer1.Value != expectedValue)
                {
                    return false;
                }
                pointer1 = pointer1.Next;
            }

            return true;
        }

        public static void TestIsPalindrome()
        {
            ListNode<int> n5 = new ListNode<int>() { Value = 1 };
            ListNode<int> n4 = new ListNode<int>() { Value = 2, Next = n5 };
            ListNode<int> n3 = new ListNode<int>() { Value = 3, Next = n4 };
            ListNode<int> n3half = new ListNode<int>() { Value = 4, Next = n3 };
            ListNode<int> n2 = new ListNode<int>() { Value = 5, Next = n3half };
            ListNode<int> n1 = new ListNode<int>() { Value = 6, Next = n2 };
            n1.PrintList();
            Console.WriteLine($"IS PALINDROME?: {Solve(n1)}");
        }
    }
}
