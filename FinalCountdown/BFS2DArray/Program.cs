using System;
using System.Collections;
using System.Collections.Generic;

namespace BFS2DArray
{
    class Program
    {
        static void Main()
        {
            /*int[,] map = new int[4, 3];  //row, column
            map[0, 0] = 1; map[0, 1] = 1; map[0, 2] = 0; map[0, 3] = 0;
            map[1, 0] = 1; map[1, 1] = 0; map[1, 2] = 0; map[1, 3] = 0;
            map[2, 0] = 0; map[2, 1] = 0; map[2, 2] = 0; map[2, 3] = 1;*/

            int[,] map = new int[,]
            {
                {1,1,0,0},
                {1,0,0,0},
                {0,0,0,1}
            };
            BFS(map);
            
            BFS(map);
            List<int[]> listA = new();
            List<int[]> listB = new();
            Search(listB, listA);
        }
        public static int Search(List<int[]> A, List<int[]> B)
        {
            int dist = A.Count * B.Count;
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < B.Count; j++)
                {
                    int val = Math.Abs(A[i][0] - B[j][0]) + Math.Abs(A[i][1] - B[j][1]);
                    if (val < dist)
                    {
                        dist = val;
                    }
                }
            }
            return dist;
        }
        public static void BFS(int[,] map)
        {
            //starting from first indicies //place current indicie in queue  //place indicies nieghbors in queue
            Queue mapNodes = new(); //visit each index in order
            int[] path = new int[map.Length]; // hold value of each index
            ArrayList visited = new(); // keep track of each index visited
            int i = 0; int j = 0;

            mapNodes.Enqueue(new int[] { i, j }); //enqueue index info [i,j] 
            visited.Add(new int[] { i, j }); //add index info [i,j] to visited
            path[0] = map[i, j]; // save index value either 0 or 1
            FindNodeMap(visited, mapNodes, map, path);
            Console.WriteLine(path.ToString());
        }
        static public int[] FindNodeMap(ArrayList visited, Queue mapNodes, int[,] map, int[] path)
        {   //check up/down, L/R
            int k = 1;
            while (mapNodes.Count > 0)
            {
                int[] curr = (int[])mapNodes.Dequeue();
                //GetLen(0) - row(3) ~~ GetLen(1) columns (4)
                if (curr[0] - 1 < map.GetLength(1) && curr[0] - 1 > 0)  
                {
                    curr[0] -= 1; //up
                    if (!visited.Contains(curr))
                    {
                        visited.Add(new int[] { curr[0], curr[1] });
                        path[k] = map[curr[0], curr[1]]; k++;
                        mapNodes.Enqueue(new int[] { curr[0], curr[1] });
                    }
                    curr[0] += 1;
                }
                if (curr[0] + 1 < map.GetLength(1) && curr[0] + 1 > 0)
                {
                    curr[0] += 1; //down
                    if (!visited.Contains(curr))
                    {
                        visited.Add(new int[] { curr[0], curr[1] });
                        path[k] = map[curr[0], curr[1]]; k++;
                        mapNodes.Enqueue(new int[] { curr[0], curr[1] });
                    }
                    curr[0] -= 1;
                }
                if (curr[1] - 1 < map.GetLength(0) && curr[1] - 1 > 0)
                {
                    curr[1] -= 1; //left
                    if (!visited.Contains(curr))
                    {
                        visited.Add(new int[] { curr[0], curr[1] });
                        path[k] = map[curr[0], curr[1]]; k++;
                        mapNodes.Enqueue(new int[] { curr[0], curr[1] });
                    }
                    curr[1] += 1;
                }
                if (curr[1] + 1 < map.GetLength(0) && curr[1] + 1 > 0)
                {
                    curr[1] += 1; //right
                    if (!visited.Contains(new int[] { curr[0], curr[1] }))
                    {
                        visited.Add(curr);
                        path[k] = map[curr[0], curr[1]]; k++;
                        mapNodes.Enqueue(new int[] { curr[0], curr[1] });
                    }
                    curr[1] -= 1;
                }

            }
            return path;
        }
    }
}
