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

            Console.WriteLine(BranchSums(tree));
        }

		public static List<int> BranchSums(BinaryTree root)
		{
			// Write your code here.
			
			Queue sumNodePair = new Queue();
			sumNodePair.Enqueue(new KeyValuePair<int, BinaryTree>(root.value, root));
			var next = new KeyValuePair<int, BinaryTree>();

			while (sumNodePair.Count != 0)
            {
				next = (KeyValuePair<int, BinaryTree>)sumNodePair.Dequeue();
				FindSum(next, sumNodePair);
			}
			return new List<int>();
		}
		public static void FindSum(KeyValuePair<int,BinaryTree> valuePair, Queue queue)
		{
			//var sumNodePair = new List<KeyValuePair<int, BinaryTree>>();
			int Rsum = valuePair.Key; int Lsum = valuePair.Key;
			BinaryTree node = valuePair.Value;
			//Queue sumNodePair = new Queue();
			//FindSum(sumNodePair.Dequeue);
			            

			if (node.right != null)
			{
				Rsum = valuePair.Key + node.right.value;
				queue.Enqueue(new KeyValuePair<int, BinaryTree>(Rsum, node.right));
			}
			if (node.left != null)
			{
				Lsum = valuePair.Key + node.left.value;
				queue.Enqueue(new KeyValuePair<int, BinaryTree>(Lsum, node.left));
			}
			
			
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
