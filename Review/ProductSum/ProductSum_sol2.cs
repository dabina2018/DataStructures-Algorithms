 using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSum
{
    class ProductSum_sol2
    {


        // Tip: You can use `el is IList<object>` to check whether an item is a list or
        // an integer.
        public static int ProductSum(List<object> array)
        {
            // Write your code here.
            int pointer = 1;
            int index = 0;
            int sum = 0;
            while (index < array.Count)
            {
                if (array[index] is int)
                {
                    sum = sum + (int)array[index] * pointer;
                }
                else
                {
                    pointer += 1;
                    List<object> tmp = (List<object>)array[index];
                    sum = sum + ProductSum(tmp);
                    pointer = 1;
                }
                index += 1;

            }
            //int finSum = finSum + sum;
            return sum;
        }

        
    }
            
}

