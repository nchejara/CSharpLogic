using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WicresoftDev.CSharpLogic.Tree
{
    public class BinarySearchTree
    {
        
        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }

        // Set Instance property so user can use all method whithout creating Object of class
        private static BinarySearchTree instance = new BinarySearchTree();
        public static BinarySearchTree Instance
        {
            get { return instance; }
        }
       
        public BinarySearchTree()
        {
            Root = null;
            Size = 0;
            
        }
        /// <summary>
        /// Add Root Node in binary tree.
        /// if user want to keep trak on thier Root node then they can keep track on it otherwise they can use InsertNode() for untrack of the Root node.
        /// </summary>
        /// <param name="newNode"></param>
        /// <returns></returns>
        public Node AddRootNode(Node newNode)
        {
            Root = newNode;
            return Root;
        }

        public int Size { get; private set; }
        public Node Root;
        

        /// <summary>
        /// Insert new Node in binary tree
        /// </summary>
        /// <param name="data"></param>
        public void InsertNode(int data)
        {
            InsertNode(Root, data);
        }
        /// <summary>
        /// Insert new node and also create Root node if it is not exists in the tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="data"></param>
        private void InsertNode(Node root, int data)
        {
            if (!IsDuplicateNode(data)) 
            {
                Size++;
                var newNode = new Node { Data = data };

                if (Root == null)
                {
                    Root = AddRootNode(newNode);
                }
                else
                {
                    if (newNode.Data < root.Data)
                    {
                        if (root.Left == null)
                        {
                            root.Left = newNode;
                        }
                        else
                        {
                            root = root.Left;
                            InsertNode(root, newNode.Data);
                        }
                    }
                    else if (newNode.Data > root.Data)
                    {
                        if (root.Right == null)
                        {
                            root.Right = newNode;
                        }
                        else
                        {
                            root = root.Right;
                            InsertNode(root, newNode.Data);
                        }
                    }
                }
            }
        }

        public Node RemoveNode(int data)
        {
            return RemoveNode(Root, data);
        }
        public Node RemoveNode(Node root, int data)
        {
            if (Root == null)
                return null;

            if (root.Data == data)
            {
                Root = root.Right;
                Node temp = Root;
                
                while (temp != null)
                {
                    //deleted root
                    


                    temp = temp.Right;
                }
                root = root.Right;
            }
            else if(root.Data < data)
            {
                root = root.Left;
                RemoveNode(root, data);
            }
            else if (root.Data > data)
            {
                root = root.Right;
                RemoveNode(root, data);
            }

            return root;
        }

        /// <summary>
        /// Show all node which are in Binary Searched Tree
        /// </summary>
        public void ShowPreOrderTree()
        {
            ShowPreOrderTree(Root);
        }
        private void ShowPreOrderTree(Node root)
        {
            if (root == null)
                return;

            ShowPreOrderTree(root.Left);
            Console.Write("[ "+ root.Data + " ] ");
            ShowPreOrderTree(root.Right);

        }

        /// <summary>
        /// Show all node which are in Binary Searched Tree
        /// </summary>
        public void ShowPostOrderTree()
        {
            ShowPostOrderTree(Root);
        }
        private void ShowPostOrderTree(Node root)
        {
            if (root == null)
                return;

            ShowPostOrderTree(root.Left);
            ShowPostOrderTree(root.Right);
            Console.Write("[ " + root.Data + " ] ");
        }

        /// <summary>
        /// Show all node which are in Binary Searched Tree
        /// </summary>
        public void ShowInOrderTree()
        {
            ShowInOrderTree(Root);
        }
        private void ShowInOrderTree(Node root)
        {
            if (root == null)
                return;

            Console.Write("[ " + root.Data + " ] ");
            ShowInOrderTree(root.Left);
            ShowInOrderTree(root.Right);

        }

        /// <summary>
        /// Check specific node in the tree. If tree contain node in the list then return true and avoid adding duplicate node  in the tree
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool IsDuplicateNode(int data)
        {
            return IsDuplicateNode(Root, data);
        }
        private bool IsDuplicateNode(Node root, int data)
        {
            if (root == null)
                return false;

            IsDuplicateNode(root.Left,data);
            if (root.Data != data)
                return false;
            IsDuplicateNode(root.Right,data);

            return true;
        }


        
    }
}
