using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public class Node
    {
        public string Name { get; set; }
        public IList<Node> Adjacent { get; set; } = new List<Node>();
        public bool Marked { get; set; } = false;
    }
}
