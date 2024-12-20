﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeNumSumProb
{
    public class SolutionII
    {
        public static void Main()
        {
            int[] array1 = { -1, 5, 10, 20, 28, 3};
            int[] array2 = { 26, 134, 135, 15, 17};
            ThreeNumberSumII(array1, array2);
            
        }
        public static List<int[]> ThreeNumberSumII(int[] array, int targetSum)
        {
            // Write your code here.
            int currentSum;
            Array.Sort(array);
            List<int[]> sumCombos = new List<int[]>();
            for (int i = 0; i < array.Length; i++)
            {
                int left = i + 1;
                int right = array.Length -1;
                while (left < right)
                {
                    currentSum = array[i] + array[left] + array[right];
                    if (currentSum == targetSum)
                    {
                        int[] combo = new int[] { array[i], array[left], array[right] };
                        sumCombos.Add(combo);
                        left += 1;
                        right -= 1;
                    }
                    else if (currentSum < targetSum)
                    {
                        left += 1;
                    }
                    else right -= 1;
                }
            }
            return sumCombos;
        } 
    }
}
 