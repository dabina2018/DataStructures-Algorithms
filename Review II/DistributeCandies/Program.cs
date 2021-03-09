using System;
using System.Collections.Generic;

namespace DistributeCandies
{
    class Program
    {
        //Alice has n candies, where the ith candy is of type candyType[i]. Alice noticed that she started to gain weight, so she visited a doctor.
        //The doctor advised Alice to only eat n / 2 of the candies she has (n is always even). 
        //Alice likes her candies very much, and she wants to eat the maximum number of different types of candies while still following the doctor's advice.
        //Given the integer array candyType of length n, return the maximum number of different types of candies 
        //she can eat if she only eats n / 2 of them.
        static void Main(string[] args)
        {
            int[] candyType = { 1, 1, 2, 2, 3, 3 };
           
            Console.WriteLine(DistributeCandies(candyType));
            //Console.WriteLine(DistributeCandiesII(candyType));
        }
        static public int DistributeCandies(int[] candyType)
        {
            int numAbleToEat = candyType.Length / 2;
            Dictionary<int, int> numOfTypes = new Dictionary<int, int>();
            for (int i = 0; i < candyType.Length; i++)
            {

                if (numOfTypes.TryGetValue(candyType[i], out int val))
                {
                    numOfTypes[candyType[i]] = val + 1;
                }
                else
                {
                    numOfTypes.Add(candyType[i], 1);
                }
            }

            int numofCandyTypes = numOfTypes.Keys.Count;

            if (numAbleToEat >= numofCandyTypes)
            {
                return numofCandyTypes;
            }
            else
                return numAbleToEat;
        }

        public static int DistributeCandiesII(int[] candyType)
        {
            HashSet<int> distinctCandies = new HashSet<int>(candyType.Length / 2);
            int count = 0;
            for (int i = 0; i < candyType.Length; i++)
            {
                if (count == candyType.Length / 2)
                {
                    break;
                }
                if (!distinctCandies.Contains(candyType[i]))
                {
                    distinctCandies.Add(candyType[i]);
                    count++;
                }
            }

            return count;
        }

        public static int DistributeCandiesIII(int[] candyType)
        {
            HashSet<int> hash = new HashSet<int>(candyType);
            int max = candyType.Length / 2;
            return max < hash.Count ? max : hash.Count;
        }
    }
}
           


 
