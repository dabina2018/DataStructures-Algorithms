using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCountdown
{
    class memoization
    {       //O(2^n)
        public static void memoizationExample(int n)
        {
            Dictionary<int, int> memo = new Dictionary<int, int>();
            if (memo.TryGetValue(n, out int val)) 
            {
                var rtr =  val;
            }
            else
            {
                memo[n] = Function(n);
            }
        }
        public static int Function(int n)
        {
            return Function(n - 2) + Function(n - 1);
        }
    }
}
