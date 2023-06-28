using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public static class TreeGraphHelper
    {
        public static void InOrderTraversal(TreeNode<int> node, int level)
        {
            if (node is not null)
            {
                InOrderTraversal(node.Left, level + 1);
                Console.WriteLine($"Level|Value: {level}|{node.Value}");
                InOrderTraversal(node.Right, level + 1);
            }
        }
    }
}
