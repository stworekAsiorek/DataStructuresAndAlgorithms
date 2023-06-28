using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A");
        }
    }


    public class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B");
        }
    }

    public class Solution
    {
        private const int AlphabetLettersNum = 26;

        public int NumDecodings(string s)
        {
            return NumDecodingsRec(s, new int[s.Length + 1]);
        }

        private int NumDecodingsRec(string s, int[] memo)
        {
            if (s.Length == 0) return 1;
            else if (s.Length == 1) return IsInRange(s) ? 1 : 0;
            memo[0] = 1;
            Console.WriteLine($"memo[0]: {memo[0]}");
            memo[1] = IsInRange(s[0].ToString()) ? 1 : 0;
            Console.WriteLine($"memo[1]: {memo[1]}");
            for (var i = 2; i < s.Length + 1; i++)
            {
                if (IsInRange(s.Substring(i - 1, 1)))
                {
                    memo[i] += memo[i - 1];
                }
                if (IsInRange(s.Substring(i - 2, 2)))
                {
                    memo[i] += memo[i - 2];
                }
                Console.WriteLine($"memo[{i}]: {memo[i]}");
            }
            return memo[s.Length];
        }

        private static bool IsInRange(string s)
        {
            Console.WriteLine($"Examined string: {s}");
            if (s.StartsWith('0'))
            {
                return false;
            }
            return int.Parse(s) <= AlphabetLettersNum;
        }
    }

}
