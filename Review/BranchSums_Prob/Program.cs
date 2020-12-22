using System;
using System.Collections;
using System.Collections.Generic;


namespace BranchSums_Prob
{
    class Program
    {
		/// <summary>
		/// Write a function that takes a Binary Tree and returns a list of its branch sums
		/// orderd from leftmost branch sum to rightmost branch sum.
		/// </summary>
        static void Main()
        {
			BinaryTree tree = new BinaryTree(1);

			tree.left = new BinaryTree(2);
			tree.right = new BinaryTree(3);

			tree.left.left = new BinaryTree(4);
			tree.left.right = new BinaryTree(5);
			tree.right.left = new BinaryTree(6);
			tree.right.right = new BinaryTree(7);

			tree.left.left.left = new BinaryTree(8);
			tree.left.left.right = new BinaryTree(9);
			tree.left.right.left = new BinaryTree(10);
			
			//////////////////////////////////////////////
			BinaryTree treet = new BinaryTree(0);

			treet.left = new BinaryTree(9);
			treet.right = new BinaryTree(1);

			treet.right.left = new BinaryTree(15);
			treet.right.right = new BinaryTree(10);

			treet.right.right.right = new BinaryTree(200);
			treet.right.right.left = new BinaryTree(100);

			Console.WriteLine(BranchSums(tree));
			//Console.WriteLine(BranchSums(treet));
		}

		public static List<int> BranchSums(BinaryTree root)
		{
			// Write your code here.
			List<int> branchSums = new List<int>();
			FindSums(root, 0, branchSums);
			return branchSums;
		}
		public static void FindSums(BinaryTree node, int runningSum, List<int> branchSums)
		{
			if (node != null)
			{
				runningSum = runningSum + node.value;
				if (node.left == null && node.right == null)
				{
					branchSums.Add(runningSum);
					return;
				}
				FindSums(node.left, runningSum, branchSums);
				FindSums(node.right, runningSum, branchSums);

			}
			else return;
		}
		

		public class BinaryTree
		{
			public int value;
			public BinaryTree left;
			public BinaryTree right;

			public BinaryTree(int value)
			{
				this.value = value;
				this.left = null;
				this.right = null;
			}
		}
	}
}
