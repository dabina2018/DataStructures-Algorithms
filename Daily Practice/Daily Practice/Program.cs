using System;

namespace Daily_Practice
{
    class Program
    {
        //Given an array nums.
        ////We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
        ///Return the running sum of nums.
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 3, 4 };
            int[] input2 = { 1, 1,1,1 };
            int[] input3 = { 1, 3,1,2,10,1 };
            Console.WriteLine(RunningSumII(input1));
        }
        
        static public int[] RunningSum(int[] nums)
        {
            int[] rtrArr = new int[nums.Length];
            // iterate thru each index in the array
            // add the current index to the next index
            // update the next index to be equal to the sum
            rtrArr[0] = nums[0];
            
            for (int i = 1; i < nums.Length; i++)
            {
                int j = 0;
                int sum = 0;
                while (j <= i)
                {
                    sum = sum + nums[j];
                    j++;
                }
                rtrArr[i] = sum;
            }
            return nums;
        }

        static public int[] RunningSumII(int[] nums)
        {
            int sum = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                nums[i] = sum;
            }
            return nums;
        }
    }
}
