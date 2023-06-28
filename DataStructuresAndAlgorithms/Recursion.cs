namespace DataStructuresAndAlgorithms
{
    public class Recursion
    {
        public static void CalculateIterative(int n)
        {
            while (n > 0) {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }

        public static void CalculateRecursive(int n)
        {
            if ( n > 0 )
            {
                int k = n * n;
                Console.WriteLine(k);
                CalculateIterative(n - 1);
            }
        }

        public static int SumIterative(int n)
        {
            int sum = 0;
            for(int i=1; i<=n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int SumRecursive(int n)
        {
            if(n > 0)
            {
                return n + SumRecursive(n-1);
            }
            return 0;
        }

        public static int FactorialRecursive(int n)
        {
            if(n == 0) return 1;
            return n * FactorialRecursive(n - 1);
        }

        public static int Fibbonacci(int n)
        {
            if (n == 0 || n == 1) return 1;
            return Fibbonacci(n-1) + Fibbonacci(n-2);
        }
    }
}
