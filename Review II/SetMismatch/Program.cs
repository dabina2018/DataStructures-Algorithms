using System;
using System.Collections.Generic;
using System.Linq;

namespace SetMismatch
{
    class Program
    {
        //You have a set of integers s, which originally contains all the numbers from 1 to n. 
        //Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, 
        //which results in repetition of one number and loss of another number.
        //You are given an integer array nums representing the data status of this set after the error.
        //Find the number that occurs twice and the number that is missing and return them in the form of an array.
        static void Main()
        {
            int[] array = new int[] { 1, 1 };
            Console.WriteLine(FindErrorNums(array));
        }
        static public int[] FindErrorNums(int[] nums)
        {
            int[] rtrArr = new int[2];
            HashSet<int> vals = new HashSet<int>(nums);


            for (int i = 1; i <= nums.Length; i++)
            {
                if (!vals.Contains(i))
                {
                    rtrArr[1] = i;
                }
                int count = 0;
                foreach (int num in nums)
                {
                    if (nums[i - 1] == num)
                    {
                        count++;
                        if (count > 1)
                        {
                            rtrArr[0] = num;
                        }
                    }
                }
            }

            return rtrArr;
        }

       
    }
}
