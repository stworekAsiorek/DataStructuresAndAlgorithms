using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public static class BuildOrder
    {
        public static IList<string> Solve(string[] nodes, Tuple<string, string>[] dependencies)
        {
            var graph = CreateGraph(nodes, dependencies);

            if(graph.Nodes.Count == 0) 
            { 
                return new List<string>();
            }

            var result = BFS(graph);
            if(result.Count < nodes.Length)
            {
                return new List<string>();
            }
            return result;
        }

        public static void Test()
        {
            //var nodes = new string[] { "a", "b", "c", "d", "e", "f" };
            //var dependencies = new Tuple<string, string>[]
            //{
            //    new Tuple<string, string>("a", "d"),
            //    new Tuple<string, string>("f", "b"),
            //    new Tuple<string, string>("b", "d"),
            //    new Tuple<string, string>("f", "a"),
            //    new Tuple<string, string>("d", "c"),
            //};

            //var nodes = new string[] { "a", "b", "c", "d", "e" };
            //var dependencies = new Tuple<string, string>[]
            //{
            //    new Tuple<string, string>("e", "a"),
            //    new Tuple<string, string>("a", "b"),
            //    new Tuple<string, string>("b", "c"),
            //    new Tuple<string, string>("c", "d"),
            //    new Tuple<string, string>("d", "a"),
            //};

            var nodes = new string[] { "a", "b", "c", "d", "e", "f", "g" };
            var dependencies = new Tuple<string, string>[]
            {
                new Tuple<string, string>("f", "c"),
                new Tuple<string, string>("f", "b"),
                new Tuple<string, string>("f", "a"),
                new Tuple<string, string>("b", "a"),
                new Tuple<string, string>("c", "a"),
                new Tuple<string, string>("a", "e"),
                new Tuple<string, string>("b", "e"),
                new Tuple<string, string>("d", "g"),
            };

            var result = Solve(nodes, dependencies);
            Console.WriteLine($"{string.Join(", ", result)}");
        }

        private static Graph CreateGraph(string[] nodes, Tuple<string, string>[] dependencies) 
        {
            var dictionary = nodes.ToDictionary(keySelector: node => node, 
                elementSelector: node => new NodeWithDependencies() { Name = node});
            
            foreach(var dependency in dependencies)
            {
                dictionary[dependency.Item1].Adjacent.Add(dictionary[dependency.Item2]);
                dictionary[dependency.Item2].DependenciesNumber += 1;
            }

            var graph = new Graph();
            foreach(var node in dictionary.Values)
            {
                if(node.DependenciesNumber == 0)
                {
                    graph.Nodes.Add(node);
                }
            }
            return graph;
        }

        private static IList<string> BFS(Graph graph)
        {
            var order = new List<string>();
            var queue = new Queue<NodeWithDependencies>();
            foreach(var node in graph.Nodes)
            {
                queue.Enqueue(node);
                order.Add(node.Name);
            }
            while(queue.Count > 0)
            {
                var node = queue.Dequeue();
                foreach(var child in node.Adjacent)
                {   
                    child.MarksNumber += 1;
                    if (child.Marked)
                    {
                        queue.Enqueue(child);
                        order.Add(child.Name);
                    }
                }
            }
            return order;
        }
    }
}
