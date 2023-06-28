using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public static class Successor
    {
        public static TreeNode<int> Solve(TreeNodeWithParent<int> node)
        {
            if(node.Right is not null)
            {
                return GetLeftMostDescendant(node.Right);
            }
            return GetOldestParentStillGreater(node.Parent, node);
        }

        public static TreeNode<int> GetLeftMostDescendant(TreeNode<int> node)
        {
            if(node.Left is null)
            {
                return node;
            }
            return GetLeftMostDescendant(node.Left);
        }

        public static TreeNodeWithParent<int> GetOldestParentStillGreater(TreeNodeWithParent<int> parentNode, TreeNodeWithParent<int> node)
        {
            if(parentNode is null)
            {
                return null;
            }
            if(!ReferenceEquals(parentNode.Left, node))
            {
                return GetOldestParentStillGreater(parentNode.Parent, parentNode);
            }
            return node;
        }
    }
}
