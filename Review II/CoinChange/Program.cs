using System;
using System.Collections.Generic;

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
            int[] coins = { 186, 419, 83, 408 };
            //int[] coins = { 5,2,1 };
            Console.WriteLine(CoinChange(coins, 6249)); 
            //output = 3 Explanation:11 = 5 + 5 + 1
            //Input: [186,419,83,408] output          6249
        }
        
        public static int CoinChange(int[] coins, int amount)
        {
            if (amount == 0)
            {
                return 0;
            }
            if (amount < 0)
            {
                return -1;
            }
            else
            {
                Array.Sort(coins);
                Array.Reverse(coins);
                coinsArr = coins;
                target = amount;
                return Helper(amount, 0);
            }
        }
        static Dictionary<int, int> cache = new() { { 0, -1 } };
        static int target;
        static int[] coinsArr;

        public static int Helper(int amt, int moves)
        {
            //int moves;
            //int amt = target;
            if (cache.TryGetValue(amt, out int cachedVal))
            {
                return cachedVal;
            }
            foreach (int coin in coinsArr)
            {
                if (amt - coin >= 0)
                { 
                    amt = amt - coin;
                    moves++;
                    if (amt == 0)
                    {
                        Console.WriteLine(target +"  " + moves);
                        if (cache.TryGetValue(target, out cachedVal))
                        {
                            if (moves < cachedVal)
                            {
                                cache[target] = moves;
                            }
                        }
                        else
                        {
                            cache.Add(11, 3);
                        }
                        //cache[target] = moves;
                    }
                    else if(amt > 0)
                    {
                        Helper(amt, moves);
                    }
                }
            }
            if (cache.ContainsKey(target))
            {
                return cache[target];
            }
            else
            {
                return -1;
            }
        }
        public static int CoinChangeII(int[] coins, int amount)
        {
            int rtr = 0;
            int amt = amount;
            int i = coins.Length-1;
            Array.Sort(coins);
            while (amt > 0)
            {
                if (i >= 0 && amt != 0)
                {
                    if (amt - coins[i] < 0)
                    {
                        i--;
                    }
                    else
                    {
                        amt -= coins[i];
                        rtr += 1;
                    }
                }
                else
                {
                    return -1;
                }
            }
            return rtr;
        }
    }
}
/*        Constraints:
        1 <= coins.length <= 12
        1 <= coins[i] <= 2^31 - 1
        0 <= amount <= 10^4  */
