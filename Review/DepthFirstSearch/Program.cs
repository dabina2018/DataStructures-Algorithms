using System;
using System.Collections.Generic;

namespace DepthFirstSearch_prob
{
    class Program
    {
		//Implement the depthFirstSearch method on the Node class
		//It takes an empty array, traverses the tree using the Depth-first Search approach (from left to right)
		//stores all the nodes names in the input array and returns it.
		static void Main()
		{
			List<string> array = new List<string>();
			Node newNode = new Node("A");
			newNode.children = new List<Node>();
			newNode.AddChild("B");
			newNode.AddChild("C");
			newNode.AddChild("D");
			newNode.children[0].children = new List<Node>();
			newNode.children[0].AddChild("E");
			newNode.children[0].AddChild("F");

			newNode.children[2].children = new List<Node>();
			newNode.children[2].AddChild("G");
			newNode.children[2].AddChild("H");

			newNode.children[0].children[1].children = new List<Node>();
			newNode.children[0].children[1].AddChild("I");
			newNode.children[0].children[1].AddChild("J");

			newNode.children[2].children[0].children = new List<Node>();
			newNode.children[2].children[0].AddChild("K");
            newNode.DepthFirstSearch(array);

		}

		public class Node
		{		
			public List<string> DepthFirstSearch(List<string> array)
			{
				// Write your code here.
				Node newNode = this;
				if (newNode == null){return array;}
				else
				{
					array.Add(newNode.name);
					foreach (Node node in children)
					{node.DepthFirstSearch(array);}
				}
				return array;
			}
			public string name;
			public List<Node> children = new List<Node>();

			public Node(string name)
			{
				this.name = name;
			}
						
			public Node AddChild(string name)
			{
				Node child = new Node(name);
				children.Add(child);
				return this;
			}

			
		}
	}
}
