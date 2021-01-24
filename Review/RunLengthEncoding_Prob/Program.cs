﻿using System;

namespace RunLengthEncoding_Prob
{
    class Program
    {
        //function takes in a non-empty string and returns its run-length encoding
        //run-length encoding: a form of losslessdata compression
        //i.e.: "AAA" == "3A"  AND "AAAAAAAAAA" == "9A3A"
        //Example: "AAAAAAAAAAAAABBCCCCDD" == 9A4A2B4C2D
        static void Main()
        {
            Console.WriteLine(RunLengthEncoding("aA"));
        }

        public static string RunLengthEncoding(string str)
        {
            // Write your code here.
            //int pointer = 1;
            int counter = 1;
            string wordmash = "";
            //int i = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (i + 1 < str.Length)
                {
                    if (str[i] != str[i + 1] || counter > 8)
                    {
                        if (counter > 0)
                        {
                            wordmash = wordmash + counter.ToString();
                        }
                        wordmash = wordmash + str[i - 1];
                        counter = 1;
                            //pointer++;                    
                    }
                    else
                    {
                        
                        //pointer++;
                        counter++;
                        
                    }
                }
                else
                {
                    if (counter > 0)
                    {
                        wordmash = wordmash + counter.ToString();
                    }
                    wordmash = wordmash + str[i];
                    return wordmash;
                }
                        
               
            }
            return wordmash;
        }
    }
}
