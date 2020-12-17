using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewPrep
{
    class ValidateSubsequence
    {

        // note: https://www.techiedelight.com/convert-array-to-list-csharp/
        static void Main()
        {
            int[] array1 = { 5, 1, 22, 25, 6, -1, 8, 10 };
            int[] array2 = { 1, 6, -1, 10 };

            IsValidSubsequence(array1.ToList(), array2.ToList());
        }

        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            //compare each index in array2 to all the values in array1 until a match is found
            //use pointer for array 1 so only the remaining portion of array is checked

            int j = 0;
            for (int i = 0; i < sequence.Capacity - 1; i++)
            {
                            
                while (sequence[i] != array[j])
                {
                    if (j < array.Capacity - 1)
                    {
                        j++;
                    }
                    else return false;
                }

            }
            return true;
        }
    }
}
