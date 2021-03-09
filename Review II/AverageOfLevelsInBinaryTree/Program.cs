using System;
using System.Collections;
using System.Collections.Generic;

namespace AverageOfLevelsInBinaryTree
{
    class Program
    {
        //Given a non-empty binary tree, return the average value of the nodes on each level
            //in the form of an array.
        static void Main()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            AverageOfLevels(root);
        }

        static Hashtable sums = new Hashtable(); //level, sum
        static Hashtable count = new Hashtable(); //level, count

        public static IList<double> AverageOfLevels(TreeNode root)
        {
            Hashtable rtr = new Hashtable();
            Helper(root, 0, sums, count);
            return HelperII(sums, count);
        }

        //create helper function
        public static void Helper(TreeNode node,  int level, Hashtable sums, Hashtable count)
        {
            Hashtable rtr = new Hashtable();
            level += 1;
            if (node == null)
            {
                return;
            }
            if (sums.Contains(level)) //check to see if level has been visted
            {
                if (!sums.ContainsValue(node.val)) //check to see if node has been visited
                {
                    sums[level] = (int)sums[level] + node.val; //update total sum for level
                    count[level] = (int)count[level] + 1; //update node count for level
                }                
            }
            else
            {
                sums.Add(level, node.val);
                count.Add(level, 1);
            }
            //recursion
            Helper(node.right, level, sums, count);
            Helper(node.left, level, sums, count);
           
        }
        
        public static IList<double> HelperII(Hashtable sums, Hashtable count)
        {
            IList<double> final = new List<double>();
            for (int i = 1; i <= sums.Count; i++)
            {
                //double num = (int)sums[i] / (int)count[i];
                final.Add((int)sums[i] / (int)count[i]);
            }
            return final;
        }

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
