using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCountdown
{       // O(V+E)    vertices + edges
        // best for finding shortest path
            // explores nodes in layers, i.e. root => all roots nieghbors, next node => all nodes nieghbors
            // done by maintaing a queue**
    class BreadthFirstSearch
    {
        static public void BFS(Node root)
        {
            Queue<Node> nodeQ = new Queue<Node>();
            Hashtable visited = new Hashtable();    //bool array to track if node is visited (graph)
            ArrayList path = new ArrayList(); //array of null values to keep track of parent nodes

            Node curr = root;
            nodeQ.Enqueue(curr);
            
            visited[curr] = true;
            path.Add(curr);
           
            while (nodeQ.Count > 0)
            {
                curr = nodeQ.Dequeue();
                if (curr.left != null)
                {
                    if (!visited.ContainsKey(curr.left))
                    {
                        nodeQ.Enqueue(curr.left);
                        visited[curr.left] = true;
                        path.Add(curr.left);
                    }
                }
                if (curr.right != null)
                {
                    if (!visited.ContainsKey(curr.right))
                    {
                        nodeQ.Enqueue(curr.right);
                        visited[curr.right] = true;
                        path.Add(curr.right);
                    }
                }
            }
            //return Hashtable of nodes
        }

        public static void ReconstuctPath(Node root, Node search, ArrayList path)
        {
            ArrayList rtr = new ArrayList();
            int end = path.IndexOf(search);
            for (int i = end; i > 0; i--)
            {
                rtr.Add(path[i]);
            }
            if (path[0] == root)
            {
               // return path;
            }
        }
    }
    public class Node
    {
        public int val;
        public Node right;
        public Node left;
        public Node(int num)
        {
            this.val = num;
            this.right = null;
            this.left = null;
        }
    }
        
}
