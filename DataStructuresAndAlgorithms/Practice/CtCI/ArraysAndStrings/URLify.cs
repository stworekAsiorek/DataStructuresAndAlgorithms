using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.ArraysAndStrings
{
    public static class URLify
    {
        //URLify
        public static string Solve(string s, int length)
        {
            var sb = new StringBuilder(s);
            var numberOfSpaces = 0;
            for (var i = 0; i < length; i++)
            {
                if (s[i] == ' ')
                {
                    numberOfSpaces += 1;
                }
            }
            for (var i = length - 1; i >= 0; i--)
            {
                var newIndex = i + numberOfSpaces * 2;
                if (sb[i] == ' ')
                {
                    numberOfSpaces -= 1;
                    newIndex = newIndex - 2;
                    sb[newIndex] = '%';
                    sb[newIndex + 1] = '2';
                    sb[newIndex + 2] = '0';

                }
                else
                {
                    sb[newIndex] = s[i];
                }
            }
            return sb.ToString();
        }

        public static void Test()
        {
            var testString = "Mr John Smith    ";
            var testLength = 13;
            var result = Solve(testString, testLength);
            Console.WriteLine(result);
        }
    }
}
