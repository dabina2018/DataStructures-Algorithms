using System;
using System.Collections.Generic;
using System.Text;

namespace SmallestDifferenceProb
{
    class SolutionII
    {
        public static int[] SmallestDifferenceII(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            int[] rtrArr = new int[2];
            int tmp = Math.Abs(arrayOne[0] - arrayTwo[0]);
            int i = 0;
            int j = 0;

            while (i < arrayOne.Length && j < arrayTwo.Length)
            {
                if (Math.Abs(arrayOne[i] - arrayTwo[j]) == 0)
                {
                    rtrArr[0] = arrayOne[i]; rtrArr[1] = arrayTwo[j];
                    return rtrArr;
                }
                else
                {
                    if (arrayOne[i] < arrayTwo[j])
                    {
                        
                        if (Math.Abs(arrayOne[i] - arrayTwo[j]) < tmp)
                        {
                            tmp = Math.Abs(arrayOne[i] - arrayTwo[j]);
                            rtrArr[0] = arrayOne[i]; rtrArr[1] = arrayTwo[j];
                        }
                        i++;
                    }
                    else
                    {
                        
                        if (Math.Abs(arrayOne[i] - arrayTwo[j]) < tmp)
                        {
                            tmp = Math.Abs(arrayOne[i] - arrayTwo[j]);
                            rtrArr[0] = arrayOne[i]; rtrArr[1] = arrayTwo[j];
                        }
                        j++;
                    }
                }
            }
            
            return rtrArr;
        }   
    }
}
