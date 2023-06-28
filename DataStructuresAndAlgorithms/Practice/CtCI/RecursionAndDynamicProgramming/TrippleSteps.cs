using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.RecursionAndDynamicProgramming
{
    public static class TrippleSteps
    {
        public static int TripleStepBottomUp(int n)
        {
            if (n == 0 || n == 1) return 0;
            else if (n == 1) return 1;
            else if (n == 2) return 2;
            int[] memo = new int[n];
            memo[0] = 1;
            memo[1] = 1;
            memo[2] = 2;
            for (int i = 3; i < n; i++)
            {
                memo[i] = memo[i - 3] + memo[i - 2] + memo[i - 1];
            }
            return memo[n - 3] + memo[n - 2] + memo[n - 1];
        }

        public static int TripleStepTopDown(int n)
        {
            return TripleStepTopDown(n, new int[n + 1]);
        }

        public static int TripleStepTopDown(int i, int[] memo)
        {
            if (i < 0) return 0;
            if (i == 0) return 1;
            if (memo[i] == 0)
            {
                memo[i] = TripleStepTopDown(i - 1, memo) + TripleStepTopDown(i - 2, memo) + TripleStepTopDown(i - 3, memo);
            }
            return memo[i];
        }

        public static void TestTripleStep(int n)
        {
            Console.WriteLine($"For {n} the TripleStepResult is: {TripleStepTopDown(n)} ");
        }
    }
}
