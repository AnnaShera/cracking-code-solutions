using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Chapter1
{
    class IsStringOneAwayReplaceOperation
    {
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
