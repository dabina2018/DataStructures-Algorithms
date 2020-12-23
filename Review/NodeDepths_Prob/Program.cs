using System;
using System.Collections.Generic;

namespace NodeDepths_Prob
{
	//write a function that takes in a Binary Tree and 
	//returns the sum of its nodes depth
	
    class Program
    {
        static void Main()
        {
			BinaryTree root = new BinaryTree(1);
			root.left = new BinaryTree(2);
			root.right = new BinaryTree(3);

			root.left.left = new BinaryTree(4);
			root.left.right = new BinaryTree(5);

			root.right.left = new BinaryTree(6);
			root.right.right = new BinaryTree(7);

			root.left.left.left = new BinaryTree(8);
			root.left.left.right = new BinaryTree(9);

            Console.WriteLine(NodeDepths(root));
        }

		public static int NodeDepths(BinaryTree root)
		{
			// Write your code here.
			int pointer = 0;
			int sum = 0;
			List<int> nodeSums = new List<int>();

			NodeCount(root, pointer, sum, nodeSums);
            foreach (int num in nodeSums)
            {
				sum = sum + num;
            }
			return sum;
		}

		public static List<int> NodeCount(BinaryTree node, int pointer, int sum, List<int> nodeSums)
        {
			if (node == null)
			{
				return nodeSums;
			}
			else
			{
				sum = sum + pointer;
				nodeSums.Add(pointer);
				pointer = pointer + 1;
				NodeCount(node.left, pointer, sum, nodeSums);
				NodeCount(node.right, pointer, sum, nodeSums);
			}
			
			
			return nodeSums;
        }

		public class BinaryTree
		{
			public int value;
			public BinaryTree left;
			public BinaryTree right;

			public BinaryTree(int value)
			{
				this.value = value;
				left = null;
				right = null;
			}
		}
	}
}
