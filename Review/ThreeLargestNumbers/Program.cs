using System;

namespace ThreeLargestNumbers
{
    class Program
    {
        //Write a function that takes in an array of the at least 3 integers
        //without sorting the input array, return a  sorted array of 3 largest integers
        static void Main()
        {
            int[] array = { 55, 7, 8 };
            Console.WriteLine(  FindThreeLargestNumbers(array));
        }
        public static int[] FindThreeLargestNumbers(int[] array)
        {
            // Write your code here.
            int[] rtrArr = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];


                if (num > rtrArr[j])
                {
                    rtrArr[j] = num;
                    Sort(rtrArr);
                    break;
                }
                return rtrArr;
            }
            return rtrArr;
        }

        public static int[] Sort(int[] array)
        {
            int tmp = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    tmp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = tmp;
                }
            }
            return array;
        }
    }
}

/*
 int[] rtrArr = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                
                if (i < 3) {rtrArr[i] = num;}
                else
                {
                    Sort(rtrArr);
                    for (int j = 0; j < rtrArr.Length; j++)
                    {
                        if (num > rtrArr[j])
                        {
                            rtrArr[j] = num;
                            Sort(rtrArr);
                            break;
                        }
                    }
                }
                
            }
            return Sort(rtrArr);
 */