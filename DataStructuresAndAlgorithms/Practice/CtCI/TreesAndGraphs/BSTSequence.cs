using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public static class BSTSequence
    {
        public static void Test()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 50};
            var BST = MinimalTree.Solve(array);
            var result = Solve(BST);
            foreach(var item in result)
            {
                Console.WriteLine($"{string.Join(", ", item)}");
            }

        }
        public static IList<IList<int>> Solve(TreeNode<int> root)
        {
            return BSTSequenceRecursive(root);
        }

        private static IList<IList<int>> BSTSequenceRecursive(TreeNode<int> root)
        {
            if(root is null)
            {
                return new List<IList<int>>();
            }

            if(root.Left is null && root.Right is null)
            {
                return new List<IList<int>>() { new List<int> { root.Value} };
            }

            var result = new List<IList<int>>();
            var subTreesSequences = new List<IList<int>>();
            var leftTreeSequences = BSTSequenceRecursive(root.Left);
            var rightTreeSequences = BSTSequenceRecursive(root.Right);
            if(!leftTreeSequences.Any())
            {
                subTreesSequences = (List<IList<int>>)rightTreeSequences;
            }
            else if (!rightTreeSequences.Any())
            {
                subTreesSequences = (List<IList<int>>)leftTreeSequences;
            }
            else
            {
                foreach (var leftTreeSequence in leftTreeSequences)
                {
                    foreach (var rightTreeSequence in rightTreeSequences)
                    {
                        MixSequences(leftTreeSequence, 0, rightTreeSequence, 0, new List<int>(), subTreesSequences);
                    }
                }
            }

            foreach(var sequence in subTreesSequences)
            {
                var sequenceWithAncestor = new List<int>() { root.Value };
                sequenceWithAncestor.AddRange(sequence);
                result.Add(sequenceWithAncestor);
            }
            return result;
        }

        private static void MixSequences(IList<int> seq1, int seq1Index, IList<int> seq2, int seq2Index, IList<int> intermediate, IList<IList<int>> result)
        {
            if(intermediate.Count == seq1.Count + seq2.Count) 
            {
                result.Add(intermediate);
                return;
            }
            if(seq1Index < seq1.Count)
            {
                var newIntermediate = intermediate.ToList();
                newIntermediate.Add(seq1[seq1Index]);
                MixSequences(seq1, seq1Index + 1, seq2, seq2Index, newIntermediate, result);
            }
            if (seq2Index < seq2.Count)
            {
                var newIntermediate = intermediate.ToList();
                newIntermediate.Add(seq2[seq2Index]);
                MixSequences(seq1, seq1Index, seq2, seq2Index + 1, newIntermediate, result);
            }
        }
    }
}
