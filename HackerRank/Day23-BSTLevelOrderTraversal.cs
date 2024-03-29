﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Node1
    {
        public Node left, right;
        public int data;
        public Node1(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
    class Day23_BSTLevelOrderTraversal
    {

        static void levelOrder(Node root)
        {
            if (root != null)
            {
                var nodeQueue = new Queue<Node>();
                nodeQueue.Enqueue(root);
                while (nodeQueue.Count > 0)
                {
                    var tree = nodeQueue.Dequeue();

                    Console.Write($"{tree.data} ");

                    if (tree.left != null)
                        nodeQueue.Enqueue(tree.left);
                    if (tree.right != null)
                        nodeQueue.Enqueue(tree.right);
                }
            }
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }
    }
}