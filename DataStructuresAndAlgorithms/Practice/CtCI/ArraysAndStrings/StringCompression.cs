using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.ArraysAndStrings
{
    public static class StringCompression
    {
        public static string Solve(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 3)
            {
                return s;
            }
            var result = new StringBuilder();
            var counter = 1;
            var previousCharacter = s[0];
            for (var i = 1; i < s.Length + 1; i++)
            {
                if (i == s.Length || s[i] != previousCharacter)
                {
                    result.Append(previousCharacter);
                    result.Append(counter);
                    counter = 1;
                    if (i < s.Length)
                    {
                        previousCharacter = s[i];
                    }
                    if (result.Length > s.Length)
                    {
                        return s;
                    }
                }
                else
                {
                    counter++;
                }
            }
            return result.ToString();
        }

        public static void Test()
        {
            var testStrings = new string[]
            {
                "aabcccccaaa",
                "aab",
                "ab"
            };

            foreach (var testString in testStrings)
            {
                var result = Solve(testString);
                Console.WriteLine($"\"{testString}\" result: {result}");
            }
        }
    }
}
