using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WicresoftDev.CSharpLogic;
using WicresoftDev.CSharpLogic.Tree;
using WicresoftDev.CSharpLogic.Stacks;

namespace LogicTest
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine(StringLogic.Reverse("Naren"));
            //Console.WriteLine(StringLogic.Trim("      N c\nM p\nKeshav     "));
            //Console.WriteLine(StringLogic.LeftTrim("      N c\nM p\nKeshav     "));
            //Console.WriteLine(StringLogic.RightTrim("      N c\nM p\nKeshav     "));
            //Console.WriteLine(StringLogic.ReverseWordByWord("   I am Naren Chejara\nand you are kumar "));
            //Console.WriteLine("Total Line : {0} || TotalWord : {1}", StringLogic.TotalLine("   I am Naren Chejara\nand you are kumar "), StringLogic.TotalWord("   I am Naren Chejara\nand you are kumar "));
            //Console.WriteLine(StringLogic.RemoveAdditionalSpace("   I      am     Naren    Chejara\nand      you     are    kumar "));
            //Console.WriteLine(StringLogic.RemoveDuplicateChar("aabbccccccccccccccccc"));
            //Console.WriteLine(StringLogic.RemoveDuplicateChar("aaabbbbbcccc"));
            ////[To do]: Below line string not work.need to sort in asending order
            //Console.WriteLine(StringLogic.RemoveDuplicateChar("abcabc"));

            // Linked List

            //LinkedList llm = new LinkedList();

            //llm.AddNode("A");
            //llm.AddNode("B"); 
            //llm.AddNode("C");
            //llm.AddNode("D");
            //llm.AddNode("E");

            //llm.ShowListOfNode();
            //Console.WriteLine("\nTotal Node are {0}", llm.size);

            //Console.WriteLine("\n{0} Node is retrived!", llm.RetriveNode(1).Data);
            //Console.WriteLine("\n{0} Node is retrived!", llm.RetriveNode("B").Data);

            //Console.WriteLine("\n Node {0}", llm.DeleteNode(2) ? "is deleted!" : "is not deleted!");
            //Console.WriteLine("\n Node {0}", llm.DeleteNode("C") ? "is deleted" : "is not deleted!");
            //llm.ShowListOfNode();
            //Console.WriteLine("\nTotal Node are {0}", llm.size);

            ////Doubly linked list

            //DoublyLinkedList list = new DoublyLinkedList();
            //list.AddNode("A");
            //list.AddNode("B");
            //list.AddNode("C");
            //list.AddNodeAtFirst("D");
            //list.AddNode("AA", 2);
            //list.AddNode("BB", 4);
            //list.ShowForwrdNodeList();
            //list.ShowBackwordNodeList();
            //Console.WriteLine("\n[ {0} ] node retrive!", list.Retrive(2).Data);
            //Console.WriteLine("\n[ {0} ] node retrive!", list.Retrive("AA").Data);
            //Console.WriteLine("\n Node {0}", list.DeleteNode(3) ? "is deleted!" : "is not deleted!");
            //Console.WriteLine("\n Node {0}", list.DeleteNode("BB") ? "is deleted!" : "is not deleted!");
            //list.ShowForwrdNodeList();
            //list.ShowBackwordNodeList();
            //Console.WriteLine("\n Node {0}", list.DeleteNode("D") ? "is deleted!" : "is not deleted!");
            //list.ShowForwrdNodeList();
            //list.ShowBackwordNodeList();

            ////Circular linked list

            //CircularLinkedList list = new CircularLinkedList();
            //list.AddNode("A");
            //list.AddNode("B");
            //list.AddNode("C");
            //list.ShowList();
            //Console.WriteLine("\n[{0}] Node retrive from list!", list.Retrive(1).Data);
            //Console.WriteLine("\n[{0}] Node retrive from list!", list.Retrive(2).Data);
            //Console.WriteLine("\n[{0}] Node retrive from list!", list.Retrive(3).Data);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("[{0}] binary is: [{1}] and total one are : [{2}]", i, DigitalLogic.DecimalToBinary(i),DigitalLogic.CountDigitBinaryNumber(GeneralLogic.DecimalToBinary(i),'1'));
            //}
            //Console.WriteLine("[{0}] reverse is [{1}]", 123, ArithmeticLogic.reverseNumber(123));
            //Console.WriteLine("[{0}] reverse is [{1}]", 123456, ArithmeticLogic.reverseNumber(123456));

            //Console.WriteLine("Sum of [{0}] is [{1}]", 123, ArithmeticLogic.SumOfDigit(123));
            //Console.WriteLine("Sum of [{0}] is [{1}]", 12345, ArithmeticLogic.SumOfDigit(12345));
            //ArithmeticLogic.SwapNumber(10, 20);
            //Console.WriteLine("\nDecimal [{0}] Hexadecimal is : [{1}]",317546, DigitalLogic.DecimalToHexadecimal(317546));
            //Console.WriteLine("\nDecimal [{0}] Octal is : [{1}]", 8, DigitalLogic.DecimalToOctal(8));
            //Console.WriteLine("\nDecimal [{0}] Octal is : [{1}]", 20, DigitalLogic.DecimalToOctal(20));
            //Console.WriteLine("\nOctal   [{0}] Decimal is : [{1}]", 24, DigitalLogic.OctalToDecimal("24"));
            //Console.WriteLine("\nOctal   [{0}] Binary is : [{1}]", 8, DigitalLogic.OctalToBinary("8"));

            int[] array = SortingLogic.BubbleSort(new int[] { 10, 2, 1, 5 });
            Console.WriteLine("Selection Sort :");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[ " + array[i] + " ] ");
            }

            Console.WriteLine("\nSelection Sort :");
            array = SortingLogic.SelectionSort(new int[] { 10, 2, 1, 5 });
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[ " + array[i] + " ] ");
            }

            Console.WriteLine("\nInsert Sort :");
            array = SortingLogic.SelectionSort(new int[] { 10, 2, 1, 5 });
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[ " + array[i] + " ] ");
            }

            Console.WriteLine("\nMerge Sort :");
            array = SortingLogic.MergeSort(new int[] { 1, 3, 7, 5 });
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[ " + array[i] + " ] ");
            }

            Console.WriteLine("\nMerge Two Array Sort :");
            array = ArrayLogic.MergeTwoArray(new int[] { 1, 2, 3, 5 }, new int[] { 6, 7, 8, 9, 10, 11, 12 });
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[ " + array[i] + " ] ");
            }

            Console.WriteLine("\nRemove duplicate item from an array :");
            array = ArrayLogic.RemoveDuplicateElement(new int[] { 6, 7, 6, 7, 10, 10, 12 });
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[ " + array[i] + " ] ");
            }

            Console.WriteLine("\nRemove specifice index element  :");
            array = ArrayLogic.RemoveAt(new int[] { 6, 7, 6, 7, 10, 10, 12 }, 3);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[ " + array[i] + " ] ");
            }

            //Binary search tree
            BinarySearchTree.Instance.InsertNode(10);
            BinarySearchTree.Instance.InsertNode(5);
            BinarySearchTree.Instance.InsertNode(2);
            BinarySearchTree.Instance.InsertNode(1);
            BinarySearchTree.Instance.InsertNode(3);
            BinarySearchTree.Instance.InsertNode(7);
            BinarySearchTree.Instance.InsertNode(6);
            BinarySearchTree.Instance.InsertNode(8);
            //Check IsDuplicateNode() method
            BinarySearchTree.Instance.InsertNode(3);
            //BinarySearchTree.Instance.InsertNode(12);
            //BinarySearchTree.Instance.InsertNode(11);
            //BinarySearchTree.Instance.InsertNode(13);

            BinarySearchTree.Instance.RemoveNode(5);
            Console.WriteLine("\n");

            Console.WriteLine("\n Show pre-order node node in tree");
            BinarySearchTree.Instance.ShowPreOrderTree();
            
            Console.WriteLine("\n Show In-order node node in tree");
            BinarySearchTree.Instance.ShowInOrderTree();
            
            Console.WriteLine("\n Show Post-order node node in tree");
            BinarySearchTree.Instance.ShowPostOrderTree();

            Console.WriteLine("\nMinmum node is : {0}", BinarySearchTree.Instance.FindMinNode().Data);
            Console.WriteLine("\nMaximum node is : {0}", BinarySearchTree.Instance.FindMaxNode().Data);
            //Recursive
            Console.WriteLine("\nMaximum node is : {0}", BinarySearchTree.Instance.FindMaxNodeRecursive().Data);
            Console.WriteLine("\nMinmum node is : {0}", BinarySearchTree.Instance.FindMinNodeRecursive().Data);
           
            
            try
            {
                //Check Stack Operation
                //push
                for (int i = 0; i <= 15; i++)
                {
                    StackLogic.Stack.Instance.Push(i);
                }

                //pop
                for (int i = 0; i <= 14; i++)
                {
                    Console.Write("[ " + StackLogic.Stack.Instance.Pop() + " ] ");
                }

                //peek
                //Console.Write("\n Peek :{0}", StackLogic.Stack.Instance.Peek());

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
