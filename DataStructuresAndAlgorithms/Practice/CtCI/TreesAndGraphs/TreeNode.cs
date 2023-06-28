using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public class TreeNode<T>
    {
        public T Value { get; init; }
        public TreeNode<T> Left { get; init; }
        public TreeNode<T> Right { get; init; }
    }
}
