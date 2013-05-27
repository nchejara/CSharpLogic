using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WicresoftDev.CSharpLogic
{
    public class DoublyLinkedList
    {
        public class Node
        {
            public Object Data { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }
        }
        public int Size { get; private set; }
        public Node Head;
        public Node Current;
        
        public  DoublyLinkedList()
        {
            Size = 0;
            Head = null;
            Current = null;
        }

        /// <summary>
        /// Add new Node at the end
        /// </summary>
        /// <param name="data"></param>
        public void AddNode(Object data)
        {
            if (!IsNodeNameDuplicate(data))
            {
                Size++;

                var newNode = new Node { Data = data };

                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    Current.Next = newNode;
                    newNode.Prev = Current;
                }

                Current = newNode;
            }
        }
        /// <summary>
        /// Add new node from the beginning
        /// </summary>
        /// <param name="data"></param>
        public void AddNodeAtFirst(Object data)
        {
            if (!IsNodeNameDuplicate(data))
            {
                Size++;

                var newNode = new Node { Data = data };

                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    newNode.Next = Head; // New node next should be point to head
                    newNode.Prev = Head.Prev; // newNode-->prev should point to null and head-->prev is null in head node 
                    Head.Prev = newNode; // Head-->Prev should point to newNode for reverse traverse ...
                    Head = newNode; // Finally newNode becomes Head Node
                }
            }
        }
        /// <summary>
        /// Add newNode at specific position
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>
        public void AddNode(Object data,int position)
        {
            if (!IsNodeNameDuplicate(data))
            {
                Size++;
                int count = 0;
                Node tempNode = Head;
                
                var newNode = new Node { Data = data };

                while(tempNode != null)                
                {
                    if (count == position - 1)
                    {
                        newNode.Next = tempNode.Next;
                        newNode.Prev = tempNode;
                        tempNode.Next.Prev = newNode;
                        tempNode.Next = newNode;
                        
                        break;
                    }
                    count++;
                
                    tempNode = tempNode.Next;
                }
            }
        }

        /// <summary>
        /// Return true if new node name is already in the list!
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool IsNodeNameDuplicate(Object data)
        {
            Node tempNode = Head;
            while (tempNode != null)
            {
                if (tempNode.Data.Equals(data))
                {
                    return true;
                }
                tempNode = tempNode.Next;
            }

            return false;
        }

        /// <summary>
        /// Show list of all avialable nodes in forword direction
        /// </summary>
        public void ShowForwrdNodeList()
        {
            Node tempNode = Head;
            Console.WriteLine("\nShow node in forward direction");
            while (tempNode != null)
            {
                Console.Write("[ " + tempNode.Data + " ]");
                tempNode = tempNode.Next;
                
            }
        }
        /// <summary>
        /// Show list of all available nodes in backword direction
        /// </summary>
        public void ShowBackwordNodeList()
        {
            Node tempNode = Current;
            Console.WriteLine("\nShow node in backword direction");
            while (tempNode != null)
            {
                Console.Write("[ " + tempNode.Data + " ]");
                tempNode = tempNode.Prev;

            }
        }

        public Node Retrive(int position)
        {
            Node tempNode = Head;
            Node retNode = null;
            int count = 0;

            while (tempNode != null)
            {
                if (count == position - 1)
                {
                    retNode = tempNode;
                    break;
                }
                count++;
                tempNode = tempNode.Next;
            }

            return retNode;
        }
        public Node Retrive(Object nodeName)
        {
            Node tempNode = Head;
            Node retNode = null;
            
            while (tempNode != null)
            {
                if (tempNode.Data.Equals(nodeName))
                {
                    retNode = tempNode;
                    break;
                }
                tempNode = tempNode.Next;
            }

            return retNode;
        }

        public bool DeleteNode(int position)
        {
            if (position == 1)
            {
                Size = 0;
                Head = null;
                Current = null;
                return false;
            }
            if (position > 1 && position <= Size)
            {
                int count = 0;
                Node tempNode = Head;
                Node lastNode = null;

                while (tempNode != null)
                {
                    if (count == position - 1)
                    {
                        lastNode.Next = tempNode.Next;
                        tempNode.Next.Prev = lastNode;
                        return true;
                        
                    }
                    count++;
                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }

            return false;
        }
        public bool DeleteNode(Object nodeName)
        {
            Node tempNode = Head;
            Node lastNode = null;
            while (tempNode != null)
            {
                if (tempNode.Data.Equals(nodeName))
                {
                    if (tempNode.Data == Head.Data)
                    {
                        Head = null;
                        Current = null;
                        Size = 0;
                        return true;
                    }

                    lastNode.Next = tempNode.Next;
                    tempNode.Next.Prev = lastNode;
                    return true;
                }
                lastNode = tempNode;
                tempNode = tempNode.Next;
            }

            return false;
        }
    }
}
