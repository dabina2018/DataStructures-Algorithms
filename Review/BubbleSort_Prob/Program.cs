using System;

namespace BubbleSort_Prob
{
    class Program
    {
        //Write a function that takes in an array of integers andreturns a sorted version of that array. 
        //Use Bubble Sort
        static void Main(string[] args)
        {
            int[] array = { 8, 5, 2, 9, 5, 6, 3 };
            Console.WriteLine( BubbleSort(array));
            Console.WriteLine(InsertionSort(array));
        }
        public static int[] BubbleSort(int[] array)
        {
            // Write your code here.
            int tmp;
            int count = 0;
            while (count < array.Length)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        tmp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = tmp;
                    }
                }
                count += 1;
            }
            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            // Write a function that takes in an array of integers and returns a sorted vesion of that array.
            //Use insertion sort


            return new int[] { };
        }
    }
}
