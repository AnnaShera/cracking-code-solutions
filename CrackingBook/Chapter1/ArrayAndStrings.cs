using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsPermutation = CrackingBook.Chapter1.IsStringAPermutation;
using IsOneWay = CrackingBook.Chapter1.IsStringOneAwayReplaceOperation;
using IsUnique = CrackingBook.Chapter1.IsStringUnique;

namespace CrackingBook.Chapter1
{
    class ArrayAndStrings
    {
        public static void DisplayChapter1Results()
        {
            //Question 1.1 Is string Unique
            string str = "abca";
            Console.WriteLine("Chapeter1 1.1 - Is {0} unique? {1}", str, IsUnique.IsStrUnique((str)));

            //Question 1.2 Check Permutation - is one string a permutation of the other
            string str1 = "aaaabbb";
            string str2 = "aaaabbb";
            Console.WriteLine("Chapeter1 1.2 - Is {0} is permutation of {1}? {2}", str2, str1, IsPermutation.IsPermutation(str1, str2));

            //Question 1.5 - check if a string is one or zero edits away (insert, delete, replace)
            string str3 = "pale";
            string str4 = "bae";
            Console.WriteLine("Chapeter1 1.5 - Is {0} one away from {1}? {2}", str3, str4, IsOneWay.OneAway(str3, str4));
        }
    }
}
