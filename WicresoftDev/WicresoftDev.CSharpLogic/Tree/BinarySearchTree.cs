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
            Size++;
            var newNode = new Node { Data = data };

            if (Root == null)
            {
                Root = AddRootNode(newNode);
            }

            InsertNode(Root, newNode);
        }
        /// <summary>
        /// Insert new node and also create Root node if it is not exists in the tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="data"></param>
        private void InsertNode(Node root, Node newNode)
        {
            if (!IsDuplicateNode(newNode.Data))
            {
                Node Current = root;
                Node Parent;
                while (true)
                {
                    Parent = Current;
                    if (newNode.Data < Current.Data)
                    {
                        Current = Current.Left;
                        if (Current == null)
                        {
                            Parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        Current = Current.Right;
                        if (Current == null)
                        {
                            Parent.Right = newNode;
                            return;
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Delete a node from the Binary tree
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool RemoveNode(int data)
        {
            if (Root == null)
                return false;

            Node NodeToRemoved;
            Node NodeToMoved;
            Node Parent = Root;
            Node Current = Root;
           
            //Case - 1
            // Search node which is going to delete and also keep track of delete node arent.
            while (Current.Data != data)
            {
                Parent = Current;
                if (data < Current.Data)
                {
                    Current = Current.Left;
                }
                else
                {
                    Current = Current.Right;
                }
            }

            //If Current == null it means "the node which you are looking in the tree that wasn't exists in tree
            if (Current == null)
                return false;
            
            NodeToRemoved = Current;

            //Case -2
            // Deleting a leaf or a node with one child: 
            // Remove the node and replace it with the child (or null if it has none)

            if (NodeToRemoved.Left == null || NodeToRemoved.Right == null)
            {
                Node Child;// keep track of it child
                if (NodeToRemoved.Left == null)
                {
                    Child = NodeToRemoved.Right;
                }
                else
                {
                    Child = NodeToRemoved.Left;
                }
            
                //If No Parent node 
                if (Parent == null)
                {
                    Root = Child;
                }
                else
                {
                    //Assign Child node to the parent based on the condition
                    if (NodeToRemoved.Data > Parent.Data)
                    {
                        Parent.Right = Child;
                    }
                    else
                    {
                        Parent.Left = Child;
                    }
                }
            }
            else
            {

                //Case - 3
                // Deleting a node with two children: 
                // Call the node to be deleted NodeToRemoved. Do not delete NodeToRemoved. 
                // Instead, choose either its in-order successor node or its in-order predecessor node, NodeToMoved. 
                // Replace the value of NodeToRemoved with the value of NodeToMoved, then delete NodeToMoved.

                NodeToMoved = FindSuccessor(NodeToRemoved);
                NodeToRemoved.Data = NodeToMoved.Data;
               // NodeToRemoved.Right = null;
            }
            return true;


        }
        private Node FindSuccessor(Node delNode)
        {
            Node SParent = delNode;
            Node Successor = delNode;
            Node Current = delNode.Right;
            while (Current != null)
            {
                SParent = Successor;
                Successor = Current;
                Current = Current.Left;
            }
            if (Successor != delNode.Right)
            {
                SParent.Left = Successor.Right;
                Successor.Right = delNode.Right;
                
            }
            return Successor;
        }


        #region "Tree Depth Traversal"

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
            Console.Write("[ " + root.Data + " ] ");
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

        #endregion

        /// <summary>
        /// Check specific node in the tree. If tree contain node in the list then return true and avoid adding duplicate node  in the tree
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool IsDuplicateNode(int data)
        {
            Node Current = Root;
            
            while (Current.Data != data)
            {
                if (data < Current.Data)
                {
                    Current = Current.Left;
                }
                else
                {
                    Current = Current.Right;
                }

                if (Current == null)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Find Minmum node in the Binary search tree
        /// </summary>
        /// <returns></returns>
        public Node FindMinNode()
        {
            Node tempNode = Root;

            if (tempNode == null)
                return null; ;

            while (tempNode.Left != null)
            {
                tempNode = tempNode.Left;
            }

            return tempNode;
        }

        /// <summary>
        /// Find maximum node in the Binary search tree
        /// </summary>
        /// <returns></returns>
        public Node FindMaxNode()
        {
            Node tempNode = Root;

            if (tempNode == null)
                return null; ;

            while (tempNode.Right != null)
            {
                tempNode = tempNode.Right;
            }

            return tempNode;
        }

        /// <summary>
        /// Find max using recursive method
        /// </summary>
        public Node FindMaxNodeRecursive()
        {
            if (Root == null)
                return null;
            return FindMaxNodeRecursive(Root);
        }
        private Node FindMaxNodeRecursive(Node root)
        {
            if (root.Right == null)
            {
                return root;
            }
            return FindMaxNodeRecursive(root.Right);
        }

        /// <summary>
        /// Find minimum node in the binary search tree ...
        /// </summary>
        /// <returns></returns>
        public Node FindMinNodeRecursive()
        {
            if (Root == null)
                return null;

            return FindMinNodeRecursive(Root);
        }
        private Node FindMinNodeRecursive(Node root)
        {
            if (root.Left == null)
            {
                return root;
            }
            return FindMinNodeRecursive(root.Left);
            
        }

    }
}
