using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Review
{
    class RedoClass1
    {
        public static string IntToRomanOrig(int num)
        {
            //create a hashset of roman numerals and thier num equivelant
            Hashtable ht = new Hashtable() { { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 },
                { "D", 500 }, { "M", 1000 }, { "IV", 4 }, { "IX", 9 }, { "XL", 40 }, { "XC", 90 }, { "CD", 400 }, { "CM", 900 } };

            //divide the input number by value of each dictionary entry
            int val = num;
            string rtr = "";
            int div = 1000;
            int tmp = 1;

            while (tmp > 0)
            {
                /*if (val / div < 1)
                {
                    div = div / 10;
                }*/
                //else
                //{
                tmp = val / div; // add var for divisor
                val = val % div;
                if (tmp * div > 10)
                {
                    foreach (object key in ht.Keys)
                    {
                        if (tmp * div == (int)ht[key])
                        {
                            rtr = rtr + key;         // add var for string
                            break;
                        }
                    }
                }
                else
                {
                    //while (tmp > 0)
                    //{
                    if (tmp == 9)
                    {
                        rtr = rtr + "IX";
                        tmp -= 9;
                    }
                    else if (tmp == 5 || tmp - 5 > 0)
                    {
                        rtr = rtr + "V";
                        tmp -= 5;
                    }
                    else if (tmp == 4 || tmp - 4 > 0)
                    {
                        rtr = rtr + "IV";
                        tmp -= 4;
                    }
                    else
                    {
                        for (int i = 0; i <= tmp; i++)
                        {
                            rtr = rtr + 'I';
                            tmp -= 1;
                        }
                    }
                    //}
                }
                div = div / 10;
                // }
                
            }
            return "";
        }
    }
}
