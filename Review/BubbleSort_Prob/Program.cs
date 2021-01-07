using System;

namespace BubbleSort_Prob
{
    class Program
    {
        //Write a function that takes in an array of integers andreturns a sorted version of that array. 
        //Use Bubble Sort
        static void Main()
        {
            int[] array = { 8, 5, 2, 9, 5, 6, 3 };
            //Console.WriteLine( BubbleSort(array));
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
            /*int?[] rtrArray= new int?[array.Length];
            int index = 0;

            foreach (int num in array)
            {
                rtrArray[index] = num;
                ShiftArray(rtrArray, index);
                index += 1;
            }
            */
            int index = 0;
            if(array.Length == 1) { return array; }
            else
            {
                foreach (int num in array)
                {
                    ShiftArrayII(array, index);
                    index += 1;
                }
                return array;
            }
            
        }

        /*public static int?[] ShiftArray(int?[] array, int index)
        {
            int pointer = index;
            if(index == 0)
            {
                return array;
            }
            while(index > 0)
            {
                if (array[index] < array[index -1])
                {
                    int tmp = (int)array[index - 1];
                    array[index - 1] = array[index];
                    array[index] = tmp;                   
                }
                index = index - 1;
            }
            return array;
        }*/

        public static int[] ShiftArrayII(int[] array, int index)
        {
            int pointer = index;
            if (index == 0)
            {
                return array;
            }
            while (index > 0)
            {
                if (array[index] < array[index - 1])
                {
                    int tmp = (int)array[index - 1];
                    array[index - 1] = array[index];
                    array[index] = tmp;
                }
                index = index - 1;
            }
            return array;
        }
    }
}
