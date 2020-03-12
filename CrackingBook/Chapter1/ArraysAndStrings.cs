using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    public static class ArraysAndStrings
    {        
        //I assume string length is 128 because alphbet is 128 english chars
        //Complexity: time O(n) space O(n)
        public static bool IsStringUnique(string str)
        {
            int len = str.Length;
            bool[] chars = new bool[128];
            if (str.Length > 128)
                return false;
            foreach (char ch in str)
            {
                if (chars[ch] == true)
                {
                    return false;
                }
                else
                {
                    chars[ch] = true;
                }
            }
            return true;
        }

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

        //Complexity: time O(n) space O(n)
        public static bool OneAway(string str1, string str2)
        {
            int lenDiff = Math.Abs(str1.Length - str2.Length);
            if (lenDiff > 1)
                return false;

            if (str1.Length == str2.Length)
            {
                return OneAwayReplaceOperation(str1, str2);

            }
            else if (str1.Length < str2.Length)
            {
                return OneAwayEditDeleteOperation(str1, str2);
            }
            else
            {
               return OneAwayEditDeleteOperation(str2, str1);
            }
          
        }

        //check if strings are one replacment away from each other
        public static bool OneAwayReplaceOperation(string str1, string str2)
        {
            bool editCount = false;
            for (int i = 0; i < str2.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    if (editCount)
                    {
                        return false;
                    }
                    editCount = true;
                }
            }
            return true;
        }

        //check is string are one insert or deletion away from each other
        public static bool OneAwayEditDeleteOperation(string str1, string str2)
        {
            bool editCount = false;
            int index1 = 0;
            int index2 = 0;
            while (index1 < str1.Length && index2 < str2.Length)
            {
                if (str1[index1] != str2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    if (editCount)
                    {
                        return false;
                    }
                    editCount = true;
                    index2++;

                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }

    }

}
