using System;
using System.Collections;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            IntToRoman(1994);
        }
        public static string IntToRoman(int num)
        {
            //create a hashset of roman numerals and thier num equivelant
            Hashtable ht = new Hashtable() { { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 }, { "D", 500 }, { "M", 1000 } };
            Hashtable htt = new Hashtable() { { "IV", 4 }, { "IX", 9 }, { "XL", 40 }, { "XC", 90 }, { "CD", 400 }, { "CM", 900 } };

            //divide the input number by value of each dictionary entry
            int val = num;
            string rtr = "";
            int div = 1000;
            int tmp = 0;
           

            while (div > 0)
            {
                if (val / div < 1)
                {
                    div = div / 10;
                }
                else
                {
                    tmp = (val / div); // add var for divisor
                    val = val % div;
                    if (div*10 - tmp*div == div || div*5 - tmp*div == div)
                    {
                        foreach (object key in htt.Keys)
                        {
                            if (tmp * div == (int)htt[key])
                            {
                                rtr = rtr + key;                        // add var for string
                                break;
                            }
                        }
                    }
                    else
                    {
                        int diff = 0;
                        while (diff != tmp)
                        {
                            foreach (object key in ht.Keys)
                            {
                                if (diff + (int)ht[key] <= tmp)
                                {
                                    diff = diff + (int)ht[key];
                                    rtr = rtr + key;
                                }
                            }
                        }                   // add var for string
                    }
                    div = div / 10;
                }
            }
            return rtr;
        }
    }
}
