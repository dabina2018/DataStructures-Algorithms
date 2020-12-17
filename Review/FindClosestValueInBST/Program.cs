using System;

namespace BSTQuestion
{
    class Program
    {
        static void Main()                 
        {
			BST tree = new BST(10);
			tree.left = new BST(5);
			tree.right = new BST(15);

			tree.left.left = new BST(2);
			tree.left.right = new BST (5);

			tree.right.right = new BST (22);
			tree.right.left = new BST(13);

			tree.left.left.left = new BST(1);
			tree.right.left.right = new BST(14);

			int target = 12;
            Console.WriteLine( FindClosestValueInBst(tree, target));
        }

		public static int FindClosestValueInBst(BST tree, int target)
		{
			// Write your code here.
			//compare target with root, choose R or L depending on value
			//compare target with next node, choose R or L depending on value
			BST pointer = tree;
			
			int returnVal = tree.value;
			while (pointer != null)
            {
				
				if(Math.Abs(target - returnVal) > Math.Abs(target - pointer.value))
                {
					returnVal = pointer.value;
                }

				if (target < pointer.value && pointer.left != null)
				{
					pointer = pointer.left;
				}
				else if (target > pointer.value && pointer.right != null)
				{
					pointer = pointer.right;
				}
				else return returnVal;
            }



			return -1;
		}

		public class BST
		{
			public int value;
			public BST left;
			public BST right;

			public BST(int value)
			{
				this.value = value;
			}

			//BST Methods: Find, FindRecursively, Insert, Remove

		}
	}
}
