using System;
using System.Collections.Generic;

namespace CeasarCipherEncryptor
{
    class Program
    {
        // given a string of lowercase letters and a non-negative int 'k'
        //write a function that returns a new string obtained by
        //shifting every letter in the input string by 'k' postions
        //letters should "wrap" around the alphabet
        static void Main()
        {

            Console.WriteLine(CaesarCypherEncryptor("abc",5));
                
        }
        public static string CaesarCypherEncryptor(string str, int key)
        {
            // Write your code here.
            str.ToLower();
            string rtrStr = "";
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j','k', 'l', 'm', 'n', 'o', 'p','q','r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int i=0;

            foreach (char letter in str)
            {
                int v = Array.IndexOf(alphabet, letter);
                int index = FindIndex(v, key);
                rtrStr += alphabet[index];
                i++;
            }
            
            return rtrStr;
        }

        
        public static int FindIndex(int value, int key)
        {
            int num = value + key;
            if (num<26)
            {
                return num;
            }
            while (num > 25)
            {
                num -= 26;
            }
            return num ;
            
            
        }
        
    }
}
