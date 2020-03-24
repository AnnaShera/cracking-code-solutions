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
            SingleLinkedList l1 = new SingleLinkedList();

            Console.WriteLine("Chapter 2 - My implemintation of a linked list");
            PerformListOperations(l1);

            Console.WriteLine("Chapter 2 -  Linked Lists");
            //Question 2.1
            PerformRemoveDups(l1);

            //Question 2.2
            ReturnKthtoLast(l1);          
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
        }

        //perform my list operations
        internal static void PerformListOperations(SingleLinkedList l1)
        {
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
            l1.PrintAllNodes("delete operation");
            l1.ReverseList();
            l1.PrintAllNodes("reverse operation");
        }


        //Question 2.1 remove duplicates from an unsorted linked list
        //with buffer and without buffer
        internal static void PerformRemoveDups(SingleLinkedList l1)
        {
            Console.WriteLine("Chapeter1 2.1 - remove duplicates from an unsorted linked list");
            l1.RemoveDups();
            l1.PrintAllNodes("after remove duplicates operaion");
            //Chapeter1 2.2 
            l1.AddFirst(5);
            l1.AddFirst(2);
            l1.AddFirst(6);
            l1.AddFirst(2);
            l1.AddLast(4);
            l1.PrintAllNodes("after insertion operstions");
            Console.WriteLine("Chapeter1 2.1 - remove duplicates with no buffer from an unsorted linked list");
            l1.RemoveDupsNoBuffer();
            l1.PrintAllNodes("after remove duplicates with no buffer");
        }

        //Question 2.2 find the kth to last element of a singly linked list
        internal static void ReturnKthtoLast(SingleLinkedList l1)
        {
            int k = 2;
            Console.Write("Chapeter1 2.2 -  element is position {0} from last ", k);
            Node found = l1.FindKToEndElem(k);
            if (found != null)
                Console.WriteLine("is {0}", found.data);
            else
                Console.WriteLine("was not found");
        }
    }
}
