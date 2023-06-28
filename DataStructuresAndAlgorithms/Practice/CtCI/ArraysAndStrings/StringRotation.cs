namespace DataStructuresAndAlgorithms.Practice.CtCI.ArraysAndStrings
{
    public class StringRotation
    {
        public static bool Solve(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                return false;
            }
            var s2doubled = s2.Concat(s2);
            return s2.Contains(s1);
        }
    }
}
