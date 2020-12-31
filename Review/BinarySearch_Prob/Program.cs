using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearch_Prob
{
    class Program
    { //write a function that takes in a sorted array of integers and a target integer
        //the function should use the binary search algo. to determine if the target
        // is contained in the array and return the index.
        static void Main()
        {
            int[] array = { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            Console.WriteLine(  BinarySearch(array, 33));
        }
        public static int BinarySearch(int[] array, int target)
        {
            // Write your code here.
            return DaSearch(array, target, 0, array.Length-1);
        }
        public static int DaSearch(int[] array, int target, int left, int right)
        {
            if (left > right) return -1;
            int midpoint = (left + right) / 2;
            int testNum = array[midpoint];
            if(testNum == target)
            {
                return midpoint;
            }
            else if(target< testNum)
            {
                return DaSearch(array, target, left, midpoint-1);
            }
            else
            {
                return DaSearch(array, target, midpoint + 1, right);
            }
            
        }
       
    }
}
