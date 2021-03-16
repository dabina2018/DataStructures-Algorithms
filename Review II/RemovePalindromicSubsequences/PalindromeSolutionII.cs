using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovePalindromicSubsequences
{
    //String is palindrome, remove whole string and number of steps will be one
    //String is not a palindrome, string contains only 'a' and 'b',
    //      remove all 'a's which is a palindrome sequence
    //      and then remove all 'b's,  number of steps would be 2.
    public class PalindromeSolutionII
    {
        public static int removePalindromeSub(String S)
        {
            if (S.Length == 0) return 0;
            for (int i = 0, j = S.Length - 1; i < j; i++, j--)
                if (S[i] != S[j])
                    return 2;
            return 1;
        }
        public int RemovePalindSub(string s)
        {
            int j = s.Length;
            if (j == 0)
                return 0;

            for (int i = 0; i <= j; i++)
            {
                if (s[i] != s[--j])
                    return 2;
            }
            return 1;
        }
    }
}
