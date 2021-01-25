﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ThreeNumSumProb
{
    class Program
    {
        //a function that takes in a non-empty array of distinct integers and 
        //an integer representing the target sum.
        //function should find all the triplests in the array that sum up to 
        //the target sum and return a 2-d array in ascending order
        //i.e.: array = [12,3,1,2,-6,5,-8,6] targetSum = 0 Output=> [[-8,2,6],[-8,3,5],[-6,1,5]]
        static void Main(string[] args)
        {
            int[] array = { 12, 3, 1, 2, -6, 5, -8, 6 };
            Console.WriteLine(  ThreeNumberSum(array, 0));
        }
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            List<int[]> sumCombos = new List<int[]>();
            foreach (int val in array)
            {
                int needed = targetSum - val;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 1; j < array.Length; j++)
                    {
                        if(i != j && array[i] != val && array[j] != val)
                        {
                            if (array[i] + array[j] == needed)
                            {
                                int[] newArray = { val, array[i], array[j] };
                                //sort the array & check for duplicate
                                ArraySort(newArray, sumCombos);
                            }
                        }
                    }
                }
            }
            return sumCombos;
        }
        public static List<int[]> ArraySort(int[] array, List<int[]> comboList)
        {
            bool check = true;
            //sort the array
            Array.Sort(array);
            //check if List contains a duplicate
            if (comboList.Count == 0)
            {
                comboList.Add(array);
                return comboList;
            }
            foreach (int[] combo in comboList)
            {
                check = ArrayCheck(array, combo);
                if (check)
                {
                    return comboList;
                }
            }
            comboList.Add(array);
            return comboList;
        }
        public static bool ArrayCheck(int[] array, int[] combo)
        {
            bool same = true;
            for (int i = 0; i < combo.Length; i++)
            {
                if (array[i] == combo[i])
                {
                    same = true;
                }
                else return false;
            }
            return same;
        }
    }
}
