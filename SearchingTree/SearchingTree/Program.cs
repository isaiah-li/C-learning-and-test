﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Enumerable.Range(0, 10).ToArray();
            var tree = GetTree(values, 0, values.Length - 1);
            Console.WriteLine("DFS:");
            DFS(tree);                  //中序深度优先遍历
            Console.WriteLine("===================================");
            Console.WriteLine("BFS:");
            BFS(tree);                  //广度优先遍历

        }

        static Node GetTree(int[] values, int li, int hi)
        {
            if (li > hi)
            {
                return null;
            }
            var mi = li + (hi - li) / 2;
            var node = new Node(values[mi]);
            node.Left = GetTree(values, li, mi - 1);
            node.Right = GetTree(values, mi + 1, hi);
            return node;
        }

        static void DFS(Node node)
        {
            if (node == null)
            {
                return;
            }
            DFS(node.Left);
            Console.WriteLine(" "+node.Value);
            DFS(node.Right);
        }

        static void BFS(Node root)
        {
            var q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                Console.WriteLine(" "+node.Value);
                if (node.Left != null)
                {
                    q.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    q.Enqueue(node.Right);
                }
            }
        }
    }

    class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
