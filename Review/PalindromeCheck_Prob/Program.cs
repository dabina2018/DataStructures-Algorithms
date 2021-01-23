using System;

namespace PalindromeCheck_Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            string strng = "abcdcba";
            Console.WriteLine(IsPalindromeII(strng));
        }
        public static bool IsPalindrome(string str)
        {
            // Write your code here.
            int i = 0;
            int j = str.Length-1;
            //char[] strArr = str.ToCharArray();
            while(i <= j)
            {
                if (str[i] == str[j])
                {
                    i++;
                    j--;
                }
                else return false;
            }
            return true;
        }
        public static bool IsPalindromeII(string str)
        {
            //reverses the given string and check to see if 
            //reversed string is equal to the original value
            string reversedstring="";
            for(int i = str.Length-1; i >=0; i--)
            {
                reversedstring += str[i];
            }
            return str.Equals(reversedstring);
        }
    }
}
