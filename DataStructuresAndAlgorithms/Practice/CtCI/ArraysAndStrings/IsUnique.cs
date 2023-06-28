namespace DataStructuresAndAlgorithms.Practice.CtCI.ArraysAndStrings
{
    // IS UNIQUE
    // Hint 1: ask about a range of characters: ASCII 128, extended ASCII 256, Unicode 150,000.
    // Hint 2: take into account range of characters, use the simplest possible data structure. For example you can use table for tracking number of ASCII characters because ASCII characters map to integers.
    // Hint 3: you can even minimize the storage size buy using int and bit operations.
    public static class IsUnique
    {
        // This solution requires most memory but suppors widest range of characters. O(n) is n.
        public static bool Solve1(string s)
        {
            var charactersSet = new HashSet<char>();
            foreach (char c in s)
            {
                if (charactersSet.Contains(c)) return false;
                charactersSet.Add(c);
            }
            return true;
        }

        // This solution doesn't require any additional memory but is more time consuming. O(n) is n^2.
        public static bool Solve2(string s)
        {
            for (var i = 0; i < s.Length; i++)
            {
                for (var j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j]) return false;
                }
            }
            return true;
        }

        // This solution assumes that only ASCII characters are included.
        // Thanks to that, it provides balance between time and space complexity. 
        // The O(n) is n.
        public static bool IsUniqueWithArray(string s)
        {
            var charsArray = new bool[128];
            foreach (var c in s)
            {
                var index = c.ToInt();
                if (charsArray[index])
                {
                    return false;
                }
                charsArray[index] = true;
            }
            return true;
        }

        // This solution assumes that only a-z characters are included.
        // Even less additional memory is required for storage because for storage you can use C# int by mapping character to specific bit of an integer.
        // The O(n) is n.
        public static bool IsUniqueWithInt(string s)
        {
            int checker = 0;
            foreach (var c in s)
            {
                var index = c.ToInt2();
                if ((checker & 1 << index) > 0)
                {
                    return false;
                }
                checker |= 1 << index;
            }
            return true;
        }

    }
}
