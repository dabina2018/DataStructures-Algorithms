using System;

namespace SmallestDifferenceProb
{
    class Program
    { 
        // function takes in two int arrays and finds the pair of nums (one from ea array)
        //whose absolute difference is closest to zero
        //returns the array containing the pairs of numbers  
        static void Main()
        {
            int[] array1 = new int[] {-1,5,10,20,3 };
            int[] array2 = new int[] { 26, 134,135,15,17};
            //SmallestDifference(array1, array2);
            SolutionII.SmallestDifferenceII(array1, array2);
        }
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            // Write your code here.
            int[] rtrArr = new int[2];
            Array.Sort(arrayOne);
            int i = 0;
            Array.Sort(arrayTwo);
            int j = 1;

            int tmp = Math.Abs(arrayOne[0] - arrayTwo[0]);
            while (i < arrayOne.Length)
            {
                while (j < arrayTwo.Length)
                {
                    if (Math.Abs(arrayOne[i] - arrayTwo[j]) < tmp)
                    {
                        rtrArr[0] = arrayOne[i]; rtrArr[1] = arrayTwo[j];
                        tmp = Math.Abs(arrayOne[i] - arrayTwo[j]);
                        j++;
                    }
                    else
                    {
                        j++;
                    }
                }
                i++;
                j = 0;
            }
            
            return rtrArr;
        }
    }
}
