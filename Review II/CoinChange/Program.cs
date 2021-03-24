using System;
using System.Collections;

namespace CoinChange
{
    class Program
    {   //You are given an integer array 'coins' representing coins of different denominations
        //and an integer amount representing a total amount of money.
        //Return the fewest number of coins that you need to make up that amount.
        //If that amount of money cannot be made up by any combination of the coins, return -1.
        //You may assume that you have an infinite number of each kind of coin.
        static void Main()
        {
            int[] coins = { 2 };
            CoinChange(coins, 3); //output = 3 Explanation:11 = 5 + 5 + 1
            //Input: coins = [2], amount = 3       Output: -1
            //Input: coins = [1], amount = 0        Output: 0
            //Input: coins = [1], amount = 1        Output: 1
            //Input: coins = [1], amount = 2        Output: 2
        }

        public static int CoinChange(int[] coins, int amount)
        {
            int rtr = 0;
            int amt = amount;
            int i = coins.Length-1;
            Array.Sort(coins);
            while (amt > 0)
            {
                while (i >= 0)
                {
                    if (amt - coins[i] < 0)
                    {
                        i--;
                    }
                    else
                    {
                        amt = amt - coins[i];
                        rtr += 1;
                    }
                }
                
            }
            if (amt == 0)
            {
                return rtr;
            }
            else
            {
                return -1;
            }
           
        }
    }
}
/*        Constraints:
        1 <= coins.length <= 12
        1 <= coins[i] <= 2^31 - 1
        0 <= amount <= 10^4  */
