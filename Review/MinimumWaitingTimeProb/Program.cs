using System;

namespace MinimumWaitingTimeProb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 1, 2, 6 };
            Console.WriteLine( MinimumWaitingTime(array));

        }
        public static int MinimumWaitingTime(int[] queries)
        {
            // Write your code here.
            //sort the array least to greatest
            int[] array = ArraySort(queries);

            //find the sum of waiting times
            int sum = 0;
            int x = 2;
            int total = 0;
            if (array.Length == 1)
            {
                sum = 0;
                return sum;
            }
            else if (array.Length == 2)
            {
                sum = array[0];
                return sum;
            }
            else
            {
                sum = array[0];
                total = sum;
                while (x < array.Length)
                {
                    sum = sum + array[x - 1];
                    total = total + sum;
                    x++;
                }
                return sum;
            }


            //return -1;
        }
        public static int[] ArraySort(int[] array)
        {
            int n = array.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped == true);
            return array;
        }
    }
}
