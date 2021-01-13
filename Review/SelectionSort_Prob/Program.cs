using System;

namespace SelectionSort_Prob
{
    class Program
    {
        //write a function that takes in an array of ints and returns a sorted
        //version of the array.
        static void Main(string[] args)
        {
            int[] array = { 8, 5, 2, 9, 5, 6, 3 };
            SelectionSort(array);
        }
        //
        public static int[] SelectionSort(int[] array)
        {
            // Write your code here.
            //int pointer = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int pointer = i;
                int tmp = 0;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[pointer] > array[j] )
                    { 
                        pointer = j;
                    }
                }
                tmp = array[i];
                array[i] = array[pointer];
                array[pointer] = tmp;
                
            }
            return array;
        }
    }
}
