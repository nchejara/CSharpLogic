using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WicresoftDev.CSharpLogic
{
    public class CircularLinkedList
    {
        public class Node
        {
            public Object Data { get; set; }
            public Node Next { get; set; }
        }

        public int Size { get; private set; }

        public Node Head;
        public Node Current;

        public CircularLinkedList()
        {
            Size = 0;
            Head = null;
            Current = null;
        }

        public void AddNode(Object Data)
        {
            Size++;
            var newNode = new Node { Data = Data };
            if (Head == null)
            {
                Head = newNode;
                Head.Next = Head;
            }
            else
            {
                newNode.Next = Head;
                Current.Next = newNode;

            }
            Current = newNode;
        }

        public void ShowList()
        {
            Node tempNode = Head;

            Console.Write("[ {0} ]", tempNode.Data);
            tempNode = tempNode.Next;

            while (tempNode != Head)
            {
                Console.Write("[ {0} ]", tempNode.Data);
                tempNode = tempNode.Next;
            }


        }

        public Node Retrive(int position)
        {

            Node tempNode = Head;
            if (position == 1)
            {
                return Head;
            }
            else
            {
                int count = 2; // count should be initilized by 2 because position start from 2 if this block executed...
                tempNode = tempNode.Next;

                while (tempNode != Head)
                {
                    if (count == position)
                    {
                        return tempNode;
                    }
                    count++;
                    tempNode = tempNode.Next;
                }
            }


            return null;
        }
    }
}
