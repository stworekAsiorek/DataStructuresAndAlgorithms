using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.ArraysAndStrings
{
    public static class OneAway
    {
        //ONE AWAY
        public static bool Solve(string s1, string s2)
        {
            var sizeDifference = s1.Length - s2.Length;
            if (Math.Abs(sizeDifference) > 1)
            {
                return false;
            }
            if (sizeDifference < 0)
            {
                var temp = s2;
                s1 = s2;
                s2 = temp;
            }
            var i = 0;
            var j = 0;
            var oneChangeOccured = false;
            while (i < s1.Length && j < s2.Length)
            {
                if (s1[i] != s2[j])
                {
                    if (oneChangeOccured)
                    {
                        return false;
                    }
                    if (sizeDifference != 0)
                    {
                        i++;
                    }
                    oneChangeOccured = true;
                }
                i++; j++;
            }
            return true;
        }

        public static void Test()
        {
            var pairs = new Tuple<string, string>[]
            {
                new Tuple<string, string> ("pale", "ple"),
                new Tuple<string, string> ("pales", "pale"),
                new Tuple<string, string> ("pale", "bale"),
                new Tuple<string, string> ("pale", "bake"),
            };
            foreach (var pair in pairs)
            {
                var result = Solve(pair.Item1, pair.Item2);
                Console.WriteLine($"String 1: \"{pair.Item1}\", string2: \"{pair.Item2}\", result: {result}");
            }
        }
    }
}
