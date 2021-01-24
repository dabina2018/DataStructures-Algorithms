using System;

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
            RunLengthEncoding("AAAAAAAAAAAAABBCCCCDD");
        }

        public static string RunLengthEncoding(string str)
        {
            // Write your code here.
            int pointer = 1;
            int counter = 0;
            string wordmash = "";


            if(str[counter] != str[pointer])
            {
                if (counter > 0)
                {
                    wordmash = wordmash + counter.ToString();
                }
                wordmash = wordmash + str[pointer - 1];
                counter = 0;
                pointer++;
                
            }
            else
            {
                while (str[counter] == str[pointer])
                {
                    pointer++;
                    counter++;
                }
                
            }
            return wordmash;
        }
    }
    
}
