using System;

namespace ThreeLargestNumbers
{
    class Program
    {
        //Write a function that takes in an array of the at least 3 integers
        //without sorting the input array, return a  sorted array of 3 largest integers
        //https://stackoverflow.com/questions/30988817/how-to-check-if-int-array-object-is-empty-in-c/30988873#:~:text=int%20is%20a%20non%2Dnullable,use%20of%20a%20nullable%20int.
        static void Main()
        {
            int[] array = { -1, -2, -3, -7, -17, -27, -18, -541, -8, -7, 7 };
            Console.WriteLine(FindThreeLargestNumbers(array));
        }
        public static int?[] FindThreeLargestNumbers(int[] array)
        {
            // Write your code here.
            int?[] rtrArr = new int?[3];
            foreach (int num in array)
                NumShift(rtrArr, num);
            return rtrArr;
        }
        static int?[] NumShift(int?[] rtrArray, int num)
        {
            if(!rtrArray[2].HasValue || num > rtrArray[2])
            {
                ArrayShifter(rtrArray, num, 2);
            }
            else if (!rtrArray[1].HasValue || num > rtrArray[1])
            {
                ArrayShifter(rtrArray, num, 1);
            }
            else if(!rtrArray[0].HasValue || num > rtrArray[0])
            {
                ArrayShifter(rtrArray, num, 0);
            }
            return rtrArray;
        }
        static int?[] ArrayShifter(int?[] rtrArray, int num, int index)
        {
            for (int i = 0; i <= index; i++)
            {
                if (i == index)
                {
                    rtrArray[i] = num;
                }
                else
                {
                    rtrArray[i] = rtrArray[i + 1];
                }
            }
            return rtrArray;
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
/*
 * public static int[] Sort(int[] array)
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
 */