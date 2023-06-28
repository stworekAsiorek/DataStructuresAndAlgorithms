using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public class TreeNodeWithParent<T>: TreeNode<T>
    {
        public TreeNodeWithParent<T> Parent { get; init; }
    }
}
