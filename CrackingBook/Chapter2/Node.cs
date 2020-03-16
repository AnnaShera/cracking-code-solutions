using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Chapter2
{
    internal class Node
    {
        internal int data;
        internal Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
