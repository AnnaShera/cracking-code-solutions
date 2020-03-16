using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleLinkedList =  CrackingBook.Chapter2.SingleLinkedList;


namespace CrackingBook.Chapter2
{
    class LinkedLists
    {
        public static void DisplayChapter2Results()
        {
            //My implemintation of linked list
            Console.WriteLine("Chapter 2 - My implemintation of a linked list");
            SingleLinkedList l1 = new SingleLinkedList();
            l1.AddLast(6);
            l1.AddFirst(1);
            l1.AddFirst(2);
            l1.AddFirst(3);
            l1.AddLast(4);
            l1.AddLast(4);
            l1.AddLast(4);
            l1.AddLast(2);
            l1.AddLast(2);
            l1.AddLast(3);
            l1.AddLast(5);
            l1.DeleteNode(1);
            l1.PrintAllNodes("after delete operation");
            l1.ReverseList();
            l1.PrintAllNodes("after reverse operation");
            l1.RemoveDups();
            l1.PrintAllNodes("after remove dups operaion operation");
        }

    }
}
