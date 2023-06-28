namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public static class RouteBetweenNodes
    {
        public static bool Solve1(Node a, Node b)
        {
            return DepthFirstSearch(a, b, Visit);
        }

        public static bool Solve2(Node a, Node b)
        {
            return BreadthFirstSearch(a, b, Visit);
        }
        private static bool DepthFirstSearch(Node root, Node b, Func<Node, Node, bool> visit)
        {
            if (root == null)
            {
                return false;
            }
            if (visit(root, b))
            {
                return true;
            }
            root.Marked = true;
            Console.WriteLine($"{root.Name}");
            foreach (var node in root.Adjacent)
            {
                if (!node.Marked)
                {
                    var subResult = DepthFirstSearch(node, b, visit);
                    if (subResult)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool BreadthFirstSearch(Node root, Node b, Func<Node, Node, bool> visit)
        {
            var queue = new Queue<Node>();
            root.Marked = true;
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var r = queue.Dequeue();
                if (visit(r, b))
                {
                    return true;
                }
                foreach (var node in root.Adjacent)
                {
                    if (!node.Marked)
                    {
                        node.Marked = true;
                        queue.Enqueue(node);
                    }
                }
            }
            return false;
        }

        private static bool Visit(Node a, Node b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }
            return false;
        }
    }
}
