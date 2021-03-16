using System;
using System.Collections;
using System.Collections.Generic;

namespace AddOneRowToTree
{
    class Program
    {
        //Given the root of a binary tree and two integers val and depth
        //add a row of nodes with value val at the given depth depth.
        //Note that the root node is at depth 1.
        //The adding rule is:
                //Given the integer depth, for each not null tree node cur at the depth depth - 1,
                //create two tree nodes with value val as cur's left subtree root and right subtree root.
                //cur's original left subtree should be the left subtree of the new left subtree root.        
                //cur's original right subtree should be the right subtree of the new right subtree root.
                //If depth == 1 that means there is no depth depth - 1 at all,
                //then create a tree node with value val as the new root of the whole original tree,
                //and the original tree is the new root's left subtree.
        static void Main()
        {
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(6);

            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(1);

            root.right.left = new TreeNode(5);
            PrintTree(root);
       
        }
        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            TreeNode newNode = new TreeNode(val);
            TreeNode current = root;
            int currDepth = depth;


            while (current != null && currDepth < depth)
            {
                current = current.left;
                depth += 1;
            }
            newNode.left = current.left;
            newNode.right = null;
            current.left = newNode;
            while (current != null && currDepth < depth)
            {
                current = current.right;
                depth += 1;
            }
            newNode.right = current.right;
            newNode.left = null;
            current.right = newNode;
            return root;
        }
        public void TraverseTree(TreeNode root, int currDepth, int desDepth)
        {
            int Depth = currDepth;
            if (root!= null && currDepth < desDepth)
            {
                TraverseTree(root.left, currDepth + 1, desDepth);
                TraverseTree(root.right, currDepth + 1, desDepth);
            }
        }
        

        public static void PrintTree(TreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.val);
                PrintTree(root.left);
                PrintTree(root.right);
            }
        }

       

       
        //--------------------------
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
      }
    }
}

//Input: root = [4,2,6,3,1,5], val = 1, depth = 2
//Output:[4,1,1,2,null,null,6,3,1,5]

//Input: root = [4,2,null,3,1], val = 1, depth = 3
//Output:[4,2,null,1,1,3,null,null,1]