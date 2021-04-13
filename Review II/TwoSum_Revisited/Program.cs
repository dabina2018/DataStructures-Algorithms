using System;


namespace TwoSum_Revisited
{
    // Given an array of integers nums and an integer target,
    // return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution,
    // and you may not use the same element twice. You can return the answer in any order.
    class Program
    {
        static void Main()
        {
            int[] nums = { 3,2,4 };
            TwoSum(nums, 6);
        }
        static public int[] TwoSum(int[] nums, int target)
        {
            //sort the array
            //create two pointers at each end of array
            // add int at each pointer
            // if the sum is the target return 
            // if the sum is less than target, move L pointer
            // if the sum is greater than target, move R pointer
            Array.Sort(nums);
            int rPoint = nums.Length - 1;
            int lPoint = 0;
            int[] rtrArr = new int[2];

            while (lPoint < rPoint)
            {
                if (nums[rPoint] + nums[lPoint] == target)
                {
                    return new int[] { lPoint, rPoint };
                }
                else if (nums[rPoint] + nums[lPoint] < target)
                {
                    lPoint++;
                }
                else if (nums[rPoint] + nums[lPoint] > target)
                {
                    rPoint--;
                }
            }
           
            
            return rtrArr;
        }

    }
}

//Example 1:
//Input: nums = [2, 7, 11, 15], target = 9
//Output:[0,1]
//Output: Because nums[0] +nums[1] == 9, we return [0, 1].