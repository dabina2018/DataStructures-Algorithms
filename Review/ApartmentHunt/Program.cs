using System;
using System.Collections;
using System.Collections.Generic;

namespace ApartmentHunt
{
    class Program
    {
        static void Main()
        {
            var block0 = new Dictionary<string, bool>() { {"gym", false}, {"school", true}, {"store", false} };
            var block1 = new Dictionary<string, bool>() { {"gym", true}, {"school", false}, {"store", false} };
            var block2 = new Dictionary<string, bool>() { {"gym", true }, {"school", true }, {"store", false} };
            var block3 = new Dictionary<string, bool>() { {"gym", false }, {"school", true }, {"store", false} };
            var block4 = new Dictionary<string, bool>() { { "gym", false }, { "school", true }, { "store", true } };
            List<Dictionary<string, bool>> blocks = new List<Dictionary<string, bool>>() { block0, block1, block2, block3, block4};
            string[] reqs = { "school", "gym", "store" };
            Console.WriteLine(ApartmentHunting(blocks, reqs));
        }
        public static int ApartmentHunting(List<Dictionary<string, bool>> blocks, string[] reqs)
        {
            // Write your code here.
            int[] MaxDistArray= new int[5];
            for (int i = 0; i < blocks.Count; i++)// iterate thru ea block to find the max dist to req bldg
            {
                //int[] maxDistanceAtBlock = new int[]();
                for (int j = 0; j < reqs.Length; j++)//iterate thru req bldg
                {
                    int closestReqDist = 4;
                    for (int k = 0; k < blocks.Count; k++) //iterate thru each block to find current req
                    {
                         blocks[k].TryGetValue(reqs[j], out bool exists);
                        if (exists)
                        {
                            closestReqDist = Math.Min(closestReqDist, DistBtwn(i, k));
                            MaxDistArray[i] = Math.Max(MaxDistArray[i], closestReqDist);
                        }
                    }
                }
            }
            return GetIndexAtMinValue(MaxDistArray);
        }
        public static int DistBtwn(int currentBlock, int currentReq)
        {
            return Math.Abs(currentBlock - currentReq);
        }
        public static int GetIndexAtMinValue(int[] MaxDistancesAtBlocks)
        {
            int minIndex = 0;
            int minIndexVal = 0;
            for (int i = 0; i < MaxDistancesAtBlocks.Length; i++)
            {
                if (MaxDistancesAtBlocks[i] < minIndexVal)
                {
                    minIndex = i;
                    minIndexVal = MaxDistancesAtBlocks[i];
                }
            }
            return minIndex;
        }
    }
}
