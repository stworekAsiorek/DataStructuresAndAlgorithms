using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.SortingAndSearching
{
    public static class SortedMerge
    {
        public static void Solve(int[] nums1, int m, int[] nums2, int n)
        {
            var a = m - 1;
            var b = n - 1;
            var c = m + n - 1;
            while (a >= 0 && b >= 0)
            {
                if (nums1[a] > nums2[b])
                {
                    nums1[c] = nums1[a];
                    a--;
                }
                else
                {
                    nums1[c] = nums2[b];
                    b--;
                }
                c--;
            }

            for (int i = 0; i <= b; i++)
            {
                nums1[c - i] = nums2[b - i];
            }
        }
    }
}
