using System;
using System.Collections.Generic;

namespace GettingADifferentNumber
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4 };
            GetDifferentNumber(array);
        }
        public static int GetDifferentNumber(int[] arr)
        {
            // your code goes here
            var numSet = new HashSet<int>(arr);

            for (int i = 0; i <= arr.Length + 1; i++)
            {
                if (!numSet.TryGetValue(i, out int val))
                {
                    return i;
                    
                }
            }
            return -1;
        }
    }
}
