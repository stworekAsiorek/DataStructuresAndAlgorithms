using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public static class CheckBalanced
    {
        public static bool Solve(TreeNode<int> root)
        {
            if(root == null) return true;
            var leftTreeHeight = CountHeightOfTree(root.Left);
            var rightTreeHeight = CountHeightOfTree(root.Right);
            if(Math.Abs(leftTreeHeight - rightTreeHeight) > 1)
            {
                return false;
            }
            return Solve(root.Left) && Solve(root.Right);
        }

        public static int CountHeightOfTree(TreeNode<int> root)
        {
            if(root is null) return 0;
            return Math.Max(CountHeightOfTree(root.Left), CountHeightOfTree(root.Right)) + 1;
        }
    }
}
