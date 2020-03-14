using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Chapter1
{
    class IsStringAPermutation
    {
        //Assumption: 128 chars in ascii representation
        //Complexity: time O(n) space O(n)
        public static Boolean IsPermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            int[] charsCount = new int[128];
            foreach (char ch in str1)
            {
                charsCount[ch]++;
            }
            foreach (char ch in str2)
            {
                charsCount[ch]--;
            }
            for (int i = 0; i < charsCount.Length; i++)
            {
                if (charsCount[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
