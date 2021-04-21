using System;

namespace RichestCustomer
{
    class Program
    {
        //You are given an m x n integer grid accounts where accounts[i][j]
        //  //is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank.
        //  //Return the wealth that the richest customer has.
        //A customer's wealth is the amount of money they have in all their bank accounts.
        //  The richest customer is the customer that has the maximum wealth.
        static void Main()
        {
            int[] row0 = { 1, 2, 3 };
            int[] row1 = { 3, 2, 1 };
            int[][] accounts = { row0, row1 };
            maximumWealth(accounts);
        }
        static public int maximumWealth(int[][] accounts)
        {
            int maxSum = 0;
            for (int i = 0; i < accounts.Length; i++) //0= row
            {
                int currSum = 0;
                for (int j = 0; j < accounts[0].Length; j++)
                {
                    currSum += accounts[i][j];
                }
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                }
            }
            return maxSum;
        }

        static public int MaximumWealthII(int[][] accounts)
        {
            int res = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int temp = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    temp += accounts[i][j];
                }
                res = Math.Max(res, temp);
            }
            return res;
        }
    }
}

//2D array int[,]