using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Node = CrackingBook.Chapter2.Node;

namespace CrackingBook.Chapter2
{
    internal class SingleLinkedList
    {
        internal Node head;

        public SingleLinkedList(){}

        public SingleLinkedList(Node head)
        {
            this.head = head;
        }

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
            Console.WriteLine("Chapter 2 - printing linked list {0}", str);
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + ", ");
                current = current.next;
            }
            Console.WriteLine();
        }

        //Complexity: time O(n) 
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
        //Complexity: time O(n) space O(n)
        public void RemoveDups()
        {
            HashSet<int> unique = new HashSet<int>();
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

        //remove duplicate values from a list
        //Complexity: time O(n^2) space O(1)
        public void RemoveDupsNoBuffer()
        {
            Node current = head;
            while (current != null)
            {
                Node runner = current;
                while (runner.next != null)
                {
                    //remove the dup node
                    if (runner.next.data == current.data)
                    {
                        runner.next = runner.next.next;
                    }
                    else
                    {
                        runner = runner.next;
                    }
                }
                current = current.next;
            }
        }

        //k=1 will return last element
        //k=2 will return second to last element and so on
        //Complexity: time O(n) + O(k) = O(n) 
        public Node FindKToEndElem(int k)
        {
            Node runner = head;
            Node current = head;
            int count = 0;
            int kToEnd = 0;
            //find number of element in one way list o(n)
            while (runner != null)
            {
                count++;
                runner = runner.next;
            }
            kToEnd = count - k;
            if (kToEnd < 0)
            {
                return null;
            }
            for (int i = 0; i < kToEnd; i++)
            {
                current = current.next;
            }
            return current;
        }
    }

}

