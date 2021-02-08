using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ShortestWordEditPath
{
    class SolutionII
    {
        public static int ShortestWordPathII(string[] words, string source, string target)
        {
            Stack wordMap = new Stack();
            wordMap.Push(source); // add source word to stack //
            HashSet<string> wordz = new HashSet<string>(words);  //Dictionary<int, string> wordDict = new Dictionary<int, string>();
            Hashtable wordsHash = new Hashtable();

            //string comparval = "";
            if (!wordz.Contains(target)) //check if target word is in dictionary, if not return -1
            {
                return -1;
            }
            else
            {
                wordMap = FindDiffs(wordz, wordMap); //find diffs from current comparison word 
                return (wordMap.Count);
               
            }
            //return -1;
        }
        public static Stack FindDiffs(HashSet<string> words, Stack wordMap)
        {
            string source = (string)wordMap.Peek();
            Hashtable newHash = new Hashtable();
            
            int counter = 0;
            while (source != "dog") //TODO - set target variable
            {
                foreach (string word in words)  // add each word and its diff to the hashtable
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] != source[i])
                        {
                            counter++;
                        }
                    }
                    if (!newHash.ContainsKey(word))
                    {
                        newHash.Add(word, counter);
                    }
                    
                    counter = 0;
                }
                if (!newHash.ContainsValue(1))
                {
                    //TODO - roll back to last word
                    words.Remove(source);
                    wordMap.Pop();
                    FindDiffs(words, wordMap);
                }
                else
                {
                    SearchDiffs(newHash, wordMap, words); // Find word with diff (1) and add to stack 
                    //remove used word
                }
            }
            return wordMap;
        }
        public static int SearchDiffs(Hashtable wordsHash, Stack wordMap, HashSet<string> words)
        {
            foreach (string word in wordsHash.Keys) //find the word with the smallest diff
            {
                if ((int)wordsHash[word] == 1)
                {             
                    wordMap.Push(word); //add the word to the stack  
                    words.Remove(word);
                    FindDiffs(words, wordMap);
                    
                }
            }
            return -1;
        }
        
    }
}
