using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class Search
    {
        public static int BinarySearchIterative(int[] A, int n, int key)
        {
            int L = 0;
            int R = n - 1;
            while (L <= R)
            {
                int m = (L + R) / 2;
                if (A[m] == key)
                {
                    return m;
                }
                if (A[m] > key)
                {
                    R = m - 1;
                }
                if (A[m] < key)
                {
                    L = m + 1;
                }
            }
            return -1;
        }

        public static int BinarySearchRecursive(int[] A, int L, int R, int key)
        {
            if (L > R)
            { 
                return -1;
            }
            int m = (L + R) / 2;
            if (A[m] == key)
            {
                return m;
            }
            if (A[m] > key)
            {
                return BinarySearchRecursive(A, L, m-1, key);
            }
            else
            {
                return BinarySearchRecursive(A, m+1, R, key);
            }
        }
    }
}
