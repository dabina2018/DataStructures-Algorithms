using System;
using System.Collections.Generic;

namespace NthFibonacci
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello World!");
            //int n = 6;
            Console.WriteLine(GetNthFib(6));
            Console.WriteLine(GetNthFib_Pt2(6));
            Console.WriteLine(GetNthFib_Pt3(6));
            Console.WriteLine(GetNthFib_Pt4(6));
        }
        public static int GetNthFib(int n)
        {
            // Write your code here.
            List<int> intList = new List<int>() { 0, 1 };
            int pointer = 1;
            int tmp = 0;

            while (pointer < n)
            {
                tmp = intList[pointer] + intList[pointer - 1];
                intList.Add(tmp);
                pointer += 1;
            }
            return intList[pointer - 1];
        }
        public static int GetNthFib_Pt2(int n)
        {
            // Write your code here.
            if (n == 2) { return 1; }
            else if (n == 1) { return 0; }
            else
            {
                return GetNthFib_Pt2(n - 1) + GetNthFib_Pt2(n - 2);
            }
        }
        public static int GetNthFib_Pt3(int n)
        {
            // Write your code here.
            int[] ints = { 0, 1 };
            int pointer = 3;
            int tmp = 0;
            while (pointer <= n)
            {
                tmp = ints[0] + ints[1];
                ints[0] = ints[1];
                ints[1] = tmp;
                pointer++;
            }          
            return tmp;
        }
        static Dictionary<int, int> NthFib = new Dictionary<int, int>();
        public static int GetNthFib_Pt4(int n)
        {
            int lookup;
            if (NthFib.TryGetValue(n, out lookup))
                return lookup;

            lookup = GetNthFib_Pt4(n - 1) + GetNthFib_Pt4(n - 2);

            NthFib[n] = lookup;
            return lookup;
        }
    }
}
