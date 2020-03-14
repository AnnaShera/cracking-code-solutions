using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Chapter1
{
    class IsStringUnique
    {
        //I assume string length is 128 because alphbet is 128 english chars
        //Complexity: time O(n) space O(n)
        public static bool IsStrUnique(string str)
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

    }
}
