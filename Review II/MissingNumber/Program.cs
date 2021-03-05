using System;
using System.Collections.Generic;

namespace MissingNumber
{
    class Program
    {
        //Given an array nums containing n distinct numbers in the range [0, n], 
        //return the only number in the range that is missing from the array.
        //Could you implement a solution using only O(1) extra space complexity 
        //  and O(n) runtime complexity?
        static void Main()
        {
            int[] array = new int[] {9, 6, 4, 2, 3, 5, 7, 0, 1};
            Console.WriteLine(MissingNumber(array));
        }
        public static int MissingNumber(int[] nums)
        {
            int max = 0;
            HashSet<int> numsHash = new HashSet<int>(nums);
            for (int i = 0; i < numsHash.Count; i++)
            {
                if (!numsHash.Contains(i))
                {
                    return i;
                }
                else
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
            }
            
            return max;
            
           
        }
    }
}
