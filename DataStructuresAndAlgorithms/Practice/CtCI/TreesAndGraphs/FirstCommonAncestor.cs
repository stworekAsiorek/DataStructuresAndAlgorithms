using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public static class FirstCommonAncestor
    {
        public static TreeNode<int> Solve(TreeNode<int> root, TreeNode<int> node1, TreeNode<int> node2)
        {
            if(root is null || node1 is null || node2 is null)
            {
                return null;
            }

            return FirstCommonAncestorRecursive(root, node1, node2);
        }
        
        private static TreeNode<int> FirstCommonAncestorRecursive(TreeNode<int> root, TreeNode<int> node1, TreeNode<int> node2)
        {
            if(root is null)
            {
                return null;
            }

            if(ReferenceEquals(root, node1) || ReferenceEquals(root, node2))
            {
                return root;
            }

            var leftTreeResult = FirstCommonAncestorRecursive(root.Left, node1, node2);
            var rightTreeResult = FirstCommonAncestorRecursive(root.Left, node1, node2);

            if(leftTreeResult is null && rightTreeResult is null) 
            {
                return null;
            }
            if (leftTreeResult is null)
            {
                return rightTreeResult;
            }
            if(rightTreeResult is null)
            {
                return leftTreeResult;
            }
            return root;
        }
    }
}
