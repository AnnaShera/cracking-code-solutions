using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Node =  CrackingBook.Chapter2.Node;

namespace CrackingBook.Chapter2
{
    internal class SingleLinkedList
    {
        internal Node head;

        public void AddFirst(int data)
        {
            Node NodeToAdd = new Node(data);
            NodeToAdd.next = head;
            head = NodeToAdd;
        }

        public void AddLast(int data)
        {
            Node NodeToAdd = new Node(data);
            if (head == null)
            {
                head = NodeToAdd;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = NodeToAdd;
            }
        }

        public void DeleteNode(int data)
        {
            //if list empty
            if (head == null)
            {
                return;
            }
            //if Node ToString delete is first
            if (head.data == data)
            {

                head = head.next;
                return;
            }
            //node to delete not first
            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }

        public void PrintAllNodes(string str)
        {
            //if list empty
            if (head == null)
            {
                return;
            }
            Console.WriteLine("Chapter 2 - printing linked list after {0}", str);
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + ", ");
                current = current.next;
            }
            Console.WriteLine();
        }


        public void ReverseList()
        {
            Node prev = null;
            Node current = head;
            Node next;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        //remove duplicate values from a list
        public void RemoveDups()
        {
            //if list empty
            if (head == null)
            {
                return;
            }

            HashSet <int> unique = new HashSet<int>();
            Node current = head;
            Node prev = null;
            while (current != null)
            {
                if (unique.Contains(current.data))
                {
                    prev.next = current.next;
                }
                else
                {
                    unique.Add(current.data);
                    prev = current;
                }
                current = current.next;
            }
        }
    }

}
     
