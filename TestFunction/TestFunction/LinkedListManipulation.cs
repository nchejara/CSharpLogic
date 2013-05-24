using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunction
{
    public class Node
    {
        public Object data { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedListManipulation
    {
        private Node Head;

        public void AddNode(Node newNode)
        {
            newNode.Next = this.Head;
            this.Head = newNode;
        }

        public void printNodes()
        {
            while (Head != null)
            {
                Console.Write(Head.data + " ");
                Head = Head.Next;
            }
        }
    }


}
