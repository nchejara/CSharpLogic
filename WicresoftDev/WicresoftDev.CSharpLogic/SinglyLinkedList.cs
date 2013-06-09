using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WicresoftDev.CSharpLogic
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

        /// <summary>
        /// Add new Node in the node List
        /// </summary>
        /// <param name="data"></param>
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
        
        /// <summary>
        /// Add node in the beginning
        /// </summary>
        /// <param name="data"></param>
        public void AddNodeFirst(Object data)
        {
            if (!IsNodeNameDuplicate(data))
            {
                size++;
                Node tempNode = Head;
                var newNode = new Node { Data = data };

                if (tempNode == null)
                {
                    Head = newNode;
                }
                else
                {
                    Head = newNode;
                    Head.Next = tempNode;
                }
            }
        }
       
        /// <summary>
        /// Add node at the end of the list
        /// </summary>
        /// <param name="data"></param>
        public void AddNodeLast(Object data)
        {
            if (!IsNodeNameDuplicate(data))
            {
                size++;

                var newNode = new Node { Data = data };
                Node tempNode = Head;
                if (tempNode == null)
                {
                    Head = newNode;
                }
                while (tempNode != null)
                {
                    if (tempNode.Next == null)
                    {
                        tempNode.Next = newNode;
                        break;
                    }
                    tempNode = tempNode.Next;
                }


            }
        }
       
        /// <summary>
        /// Add node at specific position
        /// </summary>
        /// <param name="data">Node Info</param>
        /// <param name="position">integer number</param>
        public void AddNode(Object data, int position)
        {
            if (!IsNodeNameDuplicate(data))
            {
                size++;
                int count = 0;
                Node tempNode = Head;
                Node lastNode = null;
                var newNode = new Node { Data = data };

                while (tempNode != null)
                {
                    if (count == position - 1)
                    {
                        lastNode.Next = newNode;
                        newNode.Next = tempNode;
                        break;
                    }
                    count++;
                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }
        }

        /// <summary>
        /// Avoid adding duplicate node
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Return true if newNode name already exists</returns>
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
        
        /// <summary>
        /// print all node which are linked to each othere
        /// </summary>
        public void ShowListOfNode()
        {
            Node tempNode = Head;

            while (tempNode != null)
            {
                Console.Write(tempNode.Data + " ");
                tempNode = tempNode.Next;
            }
        }

        /// <summary>
        /// Retrive specific node by passing its position
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
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
