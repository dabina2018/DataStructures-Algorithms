using System;
using System.Collections.Generic;

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
        static HashSet<string> cache = new();
        static char[] options = { '0', '1' };
        public static bool HasAllCodes(string s, int k)
        {
            // find all permutations for len 'k'
            // see if string contains each permutation
            string str = "";
            bool rtr = true;
           
            Helper(str, k);
                     
            foreach (string permutation in cache)
            {
                if (s.Contains(permutation))
                {
                    rtr = true;
                }
                else
                {
                    return false;
                }
            }
            return rtr;
        }
        public static void Helper(string str, int k)
        {
            foreach (char option in options)
            {
                str = str + option;
                foreach (char option2 in options)
                {
                    str = str + option2;
                    if (str.Length == k)
                    {
                        cache.Add(str);
                        //break;
                    }
                    else if (str.Length < k)
                    {
                        Helper(str, k);
                    }
                }
               
            }
        }
    }
}
