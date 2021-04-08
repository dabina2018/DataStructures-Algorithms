using System;

namespace BinaryString
{
    class Program
    {
        //Given a binary string s and an integer k.
        //Return true if every binary code of length k is a substring of s.
        //Otherwise, return false.
        static void Main()
        {
            string s = "00110110";
            int k = 2;
            HasAllCodes(s, k);
        }
        public static bool HasAllCodes(string s, int k)
        {
            // find all permutations for len 'k'
            // see if string contains each permutation


        }
    }
}
