using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1.1 Is string Unique
            string str = "abca";
            Console.WriteLine("is {0} unique? {1}", str, ArraysAndStrings.IsStringUnique((str)));


            //Question 1.2 Check Permutation - is one string a permutation of the other
            string str1 = "aaaabbb";
            string str2 = "aaaabbb";
            Console.WriteLine("is {0} is permutation of {1}? {2}", str2, str1, ArraysAndStrings.IsPermutation(str1,str2));

            //Question 1.4 - check if a string is one or zero edits away (insert, delete, replace)
            string str3 = "pale";
            string str4 = "bae";
            Console.WriteLine("is {0} one away from {1}? {2}", str3, str4, ArraysAndStrings.OneAway(str3, str4));
            Console.ReadLine();
           
        }



    }
}
