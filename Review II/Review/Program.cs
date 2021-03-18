using System;
using System.Collections;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntToRoman(58);
           // IntToRoman(1994);
            IntToRoman(3);
        }
        public static string IntToRoman(int num)
        {
            //create a hashset of roman numerals and thier num equivelant
            Hashtable ht = new Hashtable() { { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 }, 
                { "D", 500 }, { "M", 1000 }, { "IV", 4 }, { "IX", 9 }, { "XL", 40 }, { "XC", 90 }, { "CD", 400 }, { "CM", 900 } };
            

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
                   
                    foreach (object key in ht.Keys)
                    {
                        if (tmp * div == (int)ht[key])
                        {
                            rtr = rtr + key;         // add var for string
                            break;
                        }
                    }
                    if (tmp < 10)
                    {
                        if (tmp / 5 == 1)
                        {
                            tmp -= 5;
                            rtr = rtr + 'V';
                        }

                        for (int i = 0; i < tmp; i++)
                        {
                            rtr = rtr + 'I';
                        }
                    }
                    

                    div = div / 10;
                }
            }
            return rtr;
        }
    }
}
