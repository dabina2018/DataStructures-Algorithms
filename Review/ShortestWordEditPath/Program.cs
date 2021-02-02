using System;
using System.Collections.Generic;

namespace ShortestWordEditPath
{
    class Program
    {
        public char[] wordArray { get; set; }
        static void Main()
        {
            string source = "bit";
            string target = "dog";
            string[] words = {"but", "put", "big", "pot", "pog", "dog", "lot" };
            ShortestWordPath(words, source, target);
        }
        public static int ShortestWordPath(string[] words, string source, string target)
        {
            //create hashset with words array
            var wordsHash = new HashSet<string>(words);
            //create a queue starting with source word
            Queue<string> wordMap = new Queue<string>();
            wordMap.Enqueue(source);
            foreach (string word in words)
            {
                //replace ea letter in source word sequentially to find words from given array
                string newWord = WordSearch(source, word, wordMap);
                //search for word in hashset, if found add to queue
                if(newWord.Length != 0)
                {
                    wordMap.Enqueue(newWord);
                }
            }
            return -1;
        }
        public static string WordSearch(string source, string word, Queue<string> wordMap)
        {
            char[] sourceChar = source.ToCharArray();
            string rtrWrd = "";
            //create array with alphabet letters
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < source.Length; i++)
            {
                sourceChar[0] = alphabet[i];
                if (sourceChar.ToString() == word)
                {
                    return word;
                }
            }
            for (int i = 0; i < source.Length; i++)
            {
                sourceChar[0] = alphabet[i];
                if (sourceChar.ToString() == word)
                {
                    return word;
                }
                for (int j = 0; j < source.Length; j++)
                {
                    sourceChar[1] = alphabet[j];
                    if (sourceChar.ToString() == word)
                    {
                        return word;
                    }
                    //else return "";
                }
            }
            for (int i = 0; i < source.Length; i++)
            {
                sourceChar[0] = alphabet[i];
                if (sourceChar.ToString() == word)
                {
                    return word;
                }
                for (int j = 0; j < source.Length; j++)
                {
                    sourceChar[1] = alphabet[j];
                    if (sourceChar.ToString() == word)
                    {
                        return word;
                    }
                    for (int k = 0; k < source.Length; k++)
                    {
                        sourceChar[2] = alphabet[k];
                        if (sourceChar.ToString() == word)
                        {
                            return word;
                        }
                        else return "";
                    }
                }
            }
            return "";
        }
        public static int ShortestWordPathII(string[] words, string source, string target)
        {
            //for(i=0)
            //convert the word to a char array

            // use tmpWord = "source" tmpChangeVal = 1
            //compare each string char by char to find if they are equal, use counter to compute track of change val
            //if changeVal is < tmpChangeVal
            //tmpWord = word, tmp ChangeVal = currentChangeVal
            //pathCountVal == 1
            //source == tmpWord
            // Method: reorder array put tmp Word at index and move point++
            //if int change ==0 discard
            //return dict.count
            return -1;
        }

        public override string ToString()
        {
            string word = "";
            foreach (char letter in wordArray)
            {
                word += letter;
            }
            return word;
        }


    }
}
