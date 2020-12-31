using System;
using System.Collections.Generic;

namespace NthFibonacci
{
    //Write a function that takes in an integer and retruns the nth Fibonacci number
    // *** F(n) = F(n-1) + F(n-2), F(0) = 0 F(1) = 1
    //https://www.dotnetperls.com/memoization
    class Program
    { // 
        static void Main()
        {          
            Console.WriteLine(GetNthFib_Pt2(6));
            Console.WriteLine(GetNthFib_Pt4(6));
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

        static Dictionary<int, int> NthFib = new Dictionary<int, int> { { 2,1}, { 1,0} };
        public static int GetNthFib_Pt4(int n)
        {
            int lookup;
            
            if (NthFib.TryGetValue(n, out lookup))
                return lookup;

            lookup = GetNthFib_Pt4(n - 2) + GetNthFib_Pt4(n - 1);

            NthFib[n] = lookup;
            return lookup;
        }
    }
}
