using System;

namespace MaxSumSubArrys
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 6, 5, 2, 2, 5, 1, 9, 4 };
            MaxSumTwoNoOverlap(arr, 1, 2);
        }
        static public int MaxSumTwoNoOverlap(int[] A, int L, int M)
        {
            int spaces = L + M;
            int pointer = 0;
            int sum = 0;
            int maxInd = 0;

            while (pointer < spaces)
            {
                int maxIndInt = 0;
                for (int i = pointer; i < A.Length; i++)
                {
                    if (A[i] > maxIndInt)
                    {
                        maxIndInt = A[i];
                        maxInd = i;
                    }
                    
                }
                sum += maxIndInt;
                int tmp = A[pointer];
                A[pointer] = maxIndInt;
                A[maxInd] = tmp;
                pointer++;
            }
            return sum;
        }
    }
}
