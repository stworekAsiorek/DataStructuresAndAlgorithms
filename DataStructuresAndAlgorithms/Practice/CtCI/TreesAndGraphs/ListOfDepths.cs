using System;

namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public static class ListOfDepths
    {
        public static IList<LinkedList<TreeNode<int>>> Solve1(TreeNode<int> root)
        {
            var result = new List<LinkedList<TreeNode<int>>> ();
            var queue = new Queue<Tuple<int, TreeNode<int>>>();
            queue.Enqueue(new Tuple<int, TreeNode<int>>(0, root));
            while(queue.Count > 0)
            {
                var tuple = queue.Dequeue();
                if (tuple.Item2.Left is not null)
                {
                    queue.Enqueue(new Tuple<int, TreeNode<int>>(tuple.Item1 + 1, tuple.Item2.Left));
                }
                if(tuple.Item2.Right is not null)
                {
                    queue.Enqueue(new Tuple<int, TreeNode<int>>(tuple.Item1 + 1, tuple.Item2.Right));
                }
                if(result.Count < tuple.Item1 + 1 )
                {
                    result.Add(new LinkedList<TreeNode<int>>());
                    result.Last().AddFirst(tuple.Item2);
                }
                else
                {
                    result[tuple.Item1].AddLast(tuple.Item2);
                }
            }
            return result;
        }

        public static IList<LinkedList<TreeNode<int>>> Solve2(TreeNode<int> root)
        {
            var result = new List<LinkedList<TreeNode<int>>>();
            Solve2(root, 0, result);
            return result;
        }

        public static void Solve2(TreeNode<int> root, int level, List<LinkedList<TreeNode<int>>> result)
        {
            if(root is null)
            {
                return;
            }
            if (result.Count < level + 1)
            {
                result.Add(new LinkedList<TreeNode<int>>());
                result.Last().AddFirst(root);
            }
            else
            {
                result[level].AddLast(root);
            }
            Solve2(root.Left, level + 1, result);
            Solve2(root.Right, level + 1, result);
        }

        public static void Test1()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var tree = MinimalTree.Solve(array);
            var result = Solve1(tree);
            for(var i=0; i<result.Count; i++) 
            {
                Console.Write($"List {i}: ");
                result[i].ToList().ForEach(x => Console.Write($"{x.Value} "));
                Console.Write("\n");
            }
        }

        public static void Test2()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var tree = MinimalTree.Solve(array);
            var result = Solve2(tree);
            for (var i = 0; i < result.Count; i++)
            {
                Console.Write($"List {i}: ");
                result[i].ToList().ForEach(x => Console.Write($"{x.Value} "));
                Console.Write("\n");
            }
        }
    }
}
