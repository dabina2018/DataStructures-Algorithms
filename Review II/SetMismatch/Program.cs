using System;
using System.Collections.Generic;

namespace SetMismatch
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 1, 1};
            Console.WriteLine(FindErrorNums(array));
        }
        static public int[] FindErrorNums(int[] nums)
        {
            int[] rtrArr = new int[2];
            HashSet<int> vals = new HashSet<int>(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (!vals.Contains(i))
                {
                    rtrArr[1] = i;
                }
                int count = 0;
                foreach (int num in nums)
                {
                    
                    if (nums[i-1] == num)
                    {
                        count++;   
                        if (count > 1)
                        {
                            rtrArr[0] = num;
                            //return rtrArr;

                        }
                    }
                }
            }
            
            return rtrArr;
        }
    }
}
