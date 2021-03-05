using System;
using System.Collections;
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
            Console.WriteLine(ShortestWordPath(words, source, target));
            //SolutionII.ShortestWordPathII(words, source, target);
        }
        public static int ShortestWordPath(string[] words, string source, string target)
        {
            //create and empty hashset
            HashSet<string> wordHash = new HashSet<string>(words);            
            //create a queue starting with source word
            Queue<string> wordMap = new Queue<string>();
            wordMap.Enqueue(source);
            
            
            while (source != target)
            {
                //fill the hashtable with the words and thier diffs (from current source)
                Dictionary<int, string> wordDict = WordSearch(source, wordHash);
                //find the lowest diff in the hashtable
                
                if (wordDict.TryGetValue(1, out string newWord))
                {
                    wordMap.Enqueue(newWord);
                    wordHash.Remove(newWord);
                }
                else
                {
                    //roll back search to last word
                    wordMap.Dequeue();
                    wordDict.Add(1, newWord);
                }
                source = newWord;
            }
            return wordMap.Count-1;
        }
        //this wont work.. back tracking depth first search*
        public static Dictionary<int, string> WordSearch(string source, HashSet<string> words)
        {
            //Hashtable wordHT = new Hashtable();
            Dictionary<int, string> wordsDic = new Dictionary<int, string>();
            foreach (string word in words)
            {
                int count = 0;
                int i = 0;
                while (i < word.Length)
                {
                    if (word[i] != source[i])
                    {
                        count++;
                    }
                    i++;
                }
                try //change this to check for count of 1
                {
                    wordsDic.Add(count, word);                    
                }
                catch (Exception)
                {
                    return wordsDic;
                    //throw;
                }
                
            }
            return wordsDic;
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
