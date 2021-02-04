using System;

namespace MatrixSpiralCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int[,] array = new int[5, 4];
            Console.WriteLine(array.GetLength(0));
            Console.WriteLine(array.GetLength(1));
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    array[i, j] = counter;
                }
                
            }
        }
        public static int[] SpiralCopy(int[,] inputMatrix) //int[row,column]
        {
            // your code goes here

            int right2Lef = inputMatrix.GetLength(0);//length of row
            int left2R = 0;
            int top2bot = inputMatrix.GetLength(1); // length of column
            int bot2top = 0;
            int counter = 0;
            int[] rtrArr = new int[inputMatrix.Length];

            for (int i = 0; i < inputMatrix.GetLength(0); i++)//i=row
            {
                for (int j = 0; j < inputMatrix.GetLength(1); j++) //j=column
                {
                    //iterate thru row from R to L and add values
                    while (j < right2Lef)
                    {
                        rtrArr[counter] = inputMatrix[i, j];
                        counter++;
                        j++;
                    }
                    //iterate thru column top to bottom
                    while (i < top2bot)
                    {
                        rtrArr[counter] = inputMatrix[i, j];
                        counter++;
                        i++;
                    }
                    //iterate thru row from L to R and add values
                    while (j >= left2R)
                    {
                        rtrArr[counter] = inputMatrix[i, j];
                        counter++;
                        j--;
                    }
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
                }
            }
            return rtrArr;
        }
    }
}
