using System;
using System.Collections.Generic;
using System.Text;

namespace BranchSums_Prob
{
    public class SolutionTwo
    {
		/*public static List<int> BranchSums(BinaryTree root)
		{
			// Write your code here.

			Queue sumNodePair = new Queue();
			sumNodePair.Enqueue(new KeyValuePair<int, BinaryTree>(root.value, root));
			var next = new KeyValuePair<int, BinaryTree>();
			List<int> branchSums = new List<int>();

			while (sumNodePair.Count != 0)
			{
				next = (KeyValuePair<int, BinaryTree>)sumNodePair.Dequeue();

				if (next.Value.left == null && next.Value.right == null)
				{
					branchSums.Add(next.Key);
				}
				else
				{
					FindSum(next, sumNodePair);
				}

			}
			//branchSums.Reverse();
			return branchSums;
		}
		public static Queue FindSum(KeyValuePair<int, BinaryTree> valuePair, Queue queue)
		{
			int Rsum = valuePair.Key; int Lsum = valuePair.Key;
			BinaryTree node = valuePair.Value;
			if (node.left != null)
			{
				Lsum = valuePair.Key + node.left.value;
				queue.Enqueue(new KeyValuePair<int, BinaryTree>(Lsum, node.left));
			}
			if (node.right != null)
			{
				Rsum = valuePair.Key + node.right.value;
				queue.Enqueue(new KeyValuePair<int, BinaryTree>(Rsum, node.right));
			}
			return queue;
		}*/
	}
	
}
