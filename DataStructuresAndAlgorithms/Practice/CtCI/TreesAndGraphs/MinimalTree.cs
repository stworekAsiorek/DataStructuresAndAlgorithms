using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public static class MinimalTree
    {
        public static TreeNode<int> Solve(int[] array)
        {
            return CreateMinimalTree(array, 0, array.Length - 1);
        }

        public static TreeNode<int> CreateMinimalTree(int[] array, int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            var middle = (left + right) / 2;
            return new TreeNode<int>()
            {
                Value = array[middle],
                Left = CreateMinimalTree(array, left, middle - 1),
                Right = CreateMinimalTree(array, middle + 1, right)
            };

        }

        public static void TestCreateMinimalTree()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = Solve(array);
            TreeGraphHelper.InOrderTraversal(result, 1);
        }
    }
}
