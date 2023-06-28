namespace DataStructuresAndAlgorithms.Practice.CtCI.ArraysAndStrings
{
    public static class PalindromePermutation
    {
        public static bool Solve(string s)
        {
            s = s.ToLower();
            var checker = 0;
            foreach (var c in s)
            {
                if (c == ' ') continue;
                var position = c.ToInt2();
                checker = checker ^ 1 << position;
            }
            return checker == 0 || (checker & checker - 1) == 0;
        }

        public static void Test()
        {
            var testStrings = new string[]
            {
                "Tact Coa",
                "Zaraz",
                "To chyba nie jest palindrom"
            };

            foreach (var testString in testStrings)
            {
                var result = Solve(testString);
                Console.WriteLine($"\"{testString}\" result: {result}");
            }
        }
    }
}
