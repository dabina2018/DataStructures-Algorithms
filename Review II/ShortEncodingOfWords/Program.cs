using System;
using System.Collections.Generic;

namespace ShortEncodingOfWords
{
    class Program
    {
        static void Main()
        {
            string[] array = new string[] { "time", "me", "bell" };
            MinimumLengthEncoding(array);
        }
        public static int MinimumLengthEncoding(string[] words)
        {
            string s = "";
            List<string> wordz = new List<string>(words);
            int i = 0;
            
            if (wordz[i] != wordz[i + 1])
            {
                if (wordz[i].Contains(wordz[i + 1]))
                {
                    wordz.Remove(wordz[i+1]);
                }
            }

            foreach (string word in wordz)
            {
                s = s + word + "#";
            }

            return s.Length;
        }
    }
}
