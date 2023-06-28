using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.ArraysAndStrings
{
    public static class CheckPermutation
    {
        public static bool Solve1(string a, string b)
        {
            var sortedA = string.Concat(a.OrderBy(c => c));
            var sortedB = string.Concat(b.OrderBy(c => c));
            return string.Equals(sortedA, sortedB);
        }
    }
}
