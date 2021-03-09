using System;
using System.Collections.Generic;

namespace ShortEncodingOfWords
{
    class Program
    {
        static void Main()
        {
            string[] array = new string[] {"time", "time", "time", "time"};
            Console.WriteLine(MinimumLengthEncoding(array));
            Console.WriteLine(MinimumLengthEncodingII(array));
        }
        public static int MinimumLengthEncoding(string[] words)
        {
            string s = "";
            HashSet<string> wordz = new HashSet<string>(words);
            //int i = 0;
            if (words.Length != 1)
            {
                foreach (string wd in words)
                {
                    for (int i = 1; i < wd.Length; i++)
                    {
                        wordz.Remove(wd.Substring(i));  
                    }
                }
            }
            foreach (string word in wordz)
            {
                s = s + word + "#";
            }

            return s.Length;
        }

        public static int MinimumLengthEncodingII(string[] words)
        {
            HashSet<String> good = new HashSet<string>(words);
            foreach (String word in words)
            {
                for (int k = 1; k < word.Length; ++k)
                {
                    good.Remove(word.Substring(k));
                }
            }

            int ans = 0;
            foreach (String word in good)
                ans += word.Length + 1;
            return ans;
        }
    }
}
