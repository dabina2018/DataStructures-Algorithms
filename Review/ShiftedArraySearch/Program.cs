using System;

namespace ShiftedArraySearch
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2};
            int num = 2;
            //ShiftedArrSearch(array, num);
            Console.WriteLine(  ShiftedArrSearchII(array, num));
        }

        public static int ShiftedArrSearch(int[] shiftArr, int num)
        {
            for (int i = 0; i < shiftArr.Length; i++)
            {
                if (shiftArr[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int ShiftedArrSearchII(int[] shiftArr, int num)
        {
            
             return SearchHelper(shiftArr, 0, shiftArr.Length, num);
        }
        public static int SearchHelper(int[] array, int start, int last, int num)
        {
            int midpoint = last-start / 2;
            if(midpoint == num)
            {
                return midpoint;
            }
            //compare array[0] num
            else if (array[0] > num && array[midpoint] > num)
            {
                //eliminate the left
                SearchHelper(array, midpoint + 1, array.Length - midpoint, num);
            }
            else
            {
                //eliminate right
                SearchHelper(array, 0, midpoint - 1, num);
            }
          
            return -1;
        }
    }
}
