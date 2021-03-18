using System;
using System.Collections;
using System.Collections.Generic;

namespace Review
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine( IntToRoman(58));
            Console.WriteLine(IntToRoman(2336));
            Console.WriteLine(IntToRoman(1994));
            Console.WriteLine(IntToRoman(8));
            Console.WriteLine(IntToRoman(9));
        }
        public static string IntToRoman(int num)
        {
            Console.WriteLine( Helper(num, ""));
            return Helper(num, "");
           
        }
        static public string Helper(int tmp, string rtr )
        {
            List<KeyValuePair<string, int>> romanNums = new List<KeyValuePair<string, int>>{
                new KeyValuePair<string, int>("I", 1), new KeyValuePair<string, int>("IV", 4),
                new KeyValuePair<string, int>("V", 5), new KeyValuePair<string, int>("IX", 9), 
                new KeyValuePair<string, int>("X", 10), new KeyValuePair<string, int>("XL", 40),
                new KeyValuePair<string, int>("L", 50), new KeyValuePair<string, int>("XC", 90),
                new KeyValuePair<string, int>("C", 100), new KeyValuePair<string, int>("CD", 400),
                new KeyValuePair<string, int>("D", 500), new KeyValuePair<string, int>("CM", 900),
                new KeyValuePair<string, int>("M", 1000)};

            for (int j = romanNums.Count-1; j >= 0; j--)
            {
                //2000
                int num = romanNums[j].Value;
                while (tmp / num >= 1)
                {
                    rtr = rtr + romanNums[j].Key;
                    tmp = tmp - romanNums[j].Value;
                }
            }
            return rtr;            
        }
    }
}
