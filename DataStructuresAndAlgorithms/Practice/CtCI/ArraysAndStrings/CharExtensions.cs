namespace DataStructuresAndAlgorithms.Practice.CtCI.ArraysAndStrings
{
    public static class CharExtensions
    {
        public static int ToInt(this char c)
        {
            return c - '0';
        }

        public static int ToInt2(this char c)
        {
            return c - 'a';
        }
    }
}
