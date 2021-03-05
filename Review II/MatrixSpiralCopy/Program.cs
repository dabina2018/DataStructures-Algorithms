using System;

namespace MatrixSpiralCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int[,] array = new int[1, 2]; // rows,columns
            //Console.WriteLine(array.GetLength(0)); //return row count
            //Console.WriteLine(array.GetLength(1)); //returns column count
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = counter;
                    counter++;
                }
            }
            Console.WriteLine(SpiralCopy(array));
        }
        public static int[] SpiralCopy(int[,] inputMatrix) //int[row,column]
        {
            // your code goes here
            int right2Lef = inputMatrix.GetLength(1); // column count
            int left2R = 0;
            int top2bot = inputMatrix.GetLength(0);// row count
            int bot2top = 0;
            int counter = 0;
            int[] rtrArr = new int[inputMatrix.Length];

            int i = 0; int j = 0;
            if (inputMatrix.Length == 0)
            {
                return rtrArr;
            }
            else if (inputMatrix.Length == 1)
            {
                rtrArr[0] = inputMatrix[0, 0];
                return rtrArr;
            }
            else if (inputMatrix.GetLength(0) == 1)
            {
                for (int w = 0; w <= inputMatrix.GetLength(0); w++)
                {
                    rtrArr[w] = inputMatrix[0, w];
                }
                return rtrArr;
            }
            while (i < inputMatrix.GetLength(0) / 2)  //array.count/2 = 2 OR row.length/2 = 2
            {
                //iterate thru row from R to L and add values
                while (j < right2Lef)
                {
                    rtrArr[counter] = inputMatrix[i, j];
                    counter++;
                    j++;
                }
                i++;
                j--;
                //iterate thru column top to bottom
                while (i < top2bot)
                {
                    rtrArr[counter] = inputMatrix[i, j];
                    counter++;
                    i++;
                }
                i--;
                j--;
                //iterate thru row from L to R and add values
                while (j >= left2R)
                {
                    rtrArr[counter] = inputMatrix[i, j];
                    counter++;
                    j--;
                }
                i--;
                j++;
                //iterate thru column from bottom to top
                while (i > bot2top)
                {
                    rtrArr[counter] = inputMatrix[i, j];
                    counter++;
                    i--;
                }
                right2Lef--;
                left2R++;
                top2bot--;
                bot2top++;
                i++;
                j++;
            }
            return rtrArr;
        }
    }
}
