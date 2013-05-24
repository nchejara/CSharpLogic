using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunction
{
    
    public class LinkedList
    {
        public class Node
        {
            public Object Data { get; set; }
            public Node Next { get; set; }
        }

        public LinkedList()
        {
            this.size = 0;
            this.Head = null;
            this.Current = null;
        }
        public int size { get; private set; }
        public Node Head;
        public Node Current;

        public void AddNode(Object data)
        {
            if (!IsNodeNameDuplicate(data))
            {
                size++;
                var newNode = new Node { Data = data };

                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    Current.Next = newNode;
                }

                Current = newNode;
            }
        }
        public bool IsNodeNameDuplicate(Object data)
        {
            Node tempNode = Head;

            while (tempNode != null)
            {
                if(tempNode.Data.Equals(data))
                {
                    return true;
                }
                tempNode = tempNode.Next;
            }

            return false;
        }

        public void ShowListOfNode()
        {
            Node tempNode = Head;

            while (tempNode != null)
            {
                Console.Write(tempNode.Data + " ");
                tempNode = tempNode.Next;
            }
        }

        public Node RetriveNode(int position)
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
        public Node RetriveNode(string nodeName)
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
      
            //If position is equal to Head node then assign Head and current node null so all node will be deleted automatically
            if (position == 1)
            {
                Head = null;
                Current = null;
                size = 0;
                return true;
            }

            if (position > 1 && position <= size)
            {
                Node tempNode = Head;
                Node lastNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if ( count == position - 1)
                    {
                        size--;
                        lastNode.Next = tempNode.Next;
                        return true;
                    }
                    count++;

                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }

            }
            return false;
        }
        public bool DeleteNode(string nodeName)
        {
            Node tempNode = Head;
            Node lastNode = null;
            
            while (tempNode != null)
            {
                if (tempNode.Data.Equals(nodeName))
                {
                    size--;
                    lastNode.Next = tempNode.Next;
                    return true;
                }
                lastNode = tempNode;
                tempNode = tempNode.Next;
            }

            return false;
        }
    }

}
