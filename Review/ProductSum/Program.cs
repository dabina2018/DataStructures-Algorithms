using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductSum
{
    class Program
    {
        //https://stackoverflow.com/questions/1603170/conversion-of-system-array-to-list
        static void Main()
        {
            List<object> array = new List<object>();
            array.Add(5);
            array.Add(2);
            object[] index2 = { 7, -1 };
            array.Add(index2);
            array.Add(3);
            object[] tier3 = { -13, 8 };
            object[] tier3b = { 6, tier3, 4 };
            array.Add(tier3b);
            Console.WriteLine(ProductSum(array));
        }

        // Tip: You can use `el is IList<object>` to check whether an item is a list or
        // an integer.
        public static int ProductSum(List<object> array)
        {
            // Write your code here.
            int pointer = 1;
            object[] newArray = array.ToArray();
            return SumSum(newArray, pointer);
        }
        static int SumSum(object[] array, int pointer)
        {
            int sum = 0;
            foreach (object element in array)
            {
                if (element is int)
                {
                    sum = sum + (int)element;
                }
                else
                {
                    pointer += 1;
                    sum = sum + (SumSum((object[])element, pointer) * pointer);
                    pointer = 1;
                }
            }
            
            return sum;
        }
    }
}
