﻿using System;
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

            Console.WriteLine(StringLogic.GetQuotedWordFromString("I am \"Naren\" Chejara and work in \"Shanghai\"."));
            Console.WriteLine(StringLogic.GetQuotedWordFromString("I am \"Naren\" Chejara \" and \"work in \"Shanghai"));
            Console.WriteLine(StringLogic.CountQuotedWordFromString("I am \"Naren\" Chejara and work in \"Shanghai\"."));
            Console.WriteLine(StringLogic.CountQuotedWordFromString("I am \"Naren\" Chejara \" and \"work in \"Shanghai"));

            // Linked List

            LinkedList llm = new LinkedList();

            llm.AddNode(5);
            llm.AddNode(7);
            llm.AddNode(3);
            llm.AddNode(2);
            llm.AddNode(1);
            llm.Sort();
            llm.ShowListOfNode();
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

            //Circular linked list

            CircularLinkedList list = new CircularLinkedList();
            list.AddNode("1");
            list.AddNode("2");
            list.AddNode("3");
            list.AddNode("4");
            list.AddNode("5");
            list.AddNode("6");
            list.RemoveElementFromRoundTable(3);
            list.ShowList();
            //Console.WriteLine("\n[{0}] Node retrive from list!", list.Retrive(1).Data);
            //Console.WriteLine("\n[{0}] Node retrive from list!", list.Retrive(2).Data);
            //Console.WriteLine("\n[{0}] Node retrive from list!", list.Retrive(3).Data);

            //list.DeleteNodeContinues(2);

            ////Console.WriteLine("\n[{0}] Node Deleted from list!", list.DeleteNode(2));
            //list.ShowList();

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

            //int[] array = SortingLogic.BubbleSort(new int[] { 10, 2, 1, 5 });
            //Console.WriteLine("Selection Sort :");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("[ " + array[i] + " ] ");
            //}

            //Console.WriteLine("\nSelection Sort :");
            //array = SortingLogic.SelectionSort(new int[] { 10, 2, 1, 5 });
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("[ " + array[i] + " ] ");
            //}

            //Console.WriteLine("\nInsert Sort :");
            //array = SortingLogic.SelectionSort(new int[] { 10, 2, 1, 5 });
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("[ " + array[i] + " ] ");
            //}

            //Console.WriteLine("\nMerge Sort :");
            //array = SortingLogic.MergeSort(new int[] { 1, 3, 7, 5 });
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("[ " + array[i] + " ] ");
            //}

            //Console.WriteLine("\nMerge Two Array Sort :");
            //int[] array = ArrayLogic.MergeTwoArray(new int[] { 1, 2, 3, 6 }, new int[] { 3, 4, 5, 8, 9, 10, 11, 12 });
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("[ " + array[i] + " ] ");
            //}

            //Console.WriteLine("\nRemove duplicate item from an array :");
            //array = ArrayLogic.RemoveDuplicateElement(new int[] { 6, 7, 6, 7, 10, 10, 12 });
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("[ " + array[i] + " ] ");
            //}

            //Console.WriteLine("\nRemove specifice index element  :");
            //array = ArrayLogic.RemoveAt(new int[] { 6, 7, 6, 7, 10, 10, 12 }, 3);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("[ " + array[i] + " ] ");
            //}

            ////Binary search tree
            //BinarySearchTree.Instance.InsertNode(10);
            //BinarySearchTree.Instance.InsertNode(5);
            //BinarySearchTree.Instance.InsertNode(2);
            //BinarySearchTree.Instance.InsertNode(1);
            //BinarySearchTree.Instance.InsertNode(3);
            //BinarySearchTree.Instance.InsertNode(7);
            //BinarySearchTree.Instance.InsertNode(6);
            //BinarySearchTree.Instance.InsertNode(8);
            ////Check IsDuplicateNode() method
            //BinarySearchTree.Instance.InsertNode(3);
            ////BinarySearchTree.Instance.InsertNode(12);
            ////BinarySearchTree.Instance.InsertNode(11);
            ////BinarySearchTree.Instance.InsertNode(13);

            //BinarySearchTree.Instance.RemoveNode(5);
            //Console.WriteLine("\n");

            //Console.WriteLine("\n Show pre-order node node in tree");
            //BinarySearchTree.Instance.ShowPreOrderTree();

            //Console.WriteLine("\n Show In-order node node in tree");
            //BinarySearchTree.Instance.ShowInOrderTree();

            //Console.WriteLine("\n Show Post-order node node in tree");
            //BinarySearchTree.Instance.ShowPostOrderTree();

            //Console.WriteLine("\nMinmum node is : {0}", BinarySearchTree.Instance.FindMinNode().Data);
            //Console.WriteLine("\nMaximum node is : {0}", BinarySearchTree.Instance.FindMaxNode().Data);
            ////Recursive
            //Console.WriteLine("\nMaximum node is : {0}", BinarySearchTree.Instance.FindMaxNodeRecursive().Data);
            //Console.WriteLine("\nMinmum node is : {0}", BinarySearchTree.Instance.FindMinNodeRecursive().Data);


            //try
            //{
            //    //Check Stack Operation
            //    //push
            //    for (int i = 0; i <= 15; i++)
            //    {
            //        Stack.Instance.Push(i);
            //    }

            //    //pop
            //    for (int i = 0; i < 14; i++)
            //    {
            //        Console.Write("[ " + Stack.Instance.Pop() + " ] ");
            //    }

            //    //peek
            //    Console.Write("\n Peek :{0}", Stack.Instance.Peek());

            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            Console.WriteLine("add : 0001 + 0001 = {0}", DigitalLogic.AddBinaryNumber("0001", "0001"));
            Console.WriteLine("add : 0001 + 0010 = {0}", DigitalLogic.AddBinaryNumber("0001", "0010"));
            Console.WriteLine("add : 0001 + 0011 = {0}", DigitalLogic.AddBinaryNumber("0001", "0011"));
            Console.WriteLine("add : 0001 + 0100 = {0}", DigitalLogic.AddBinaryNumber("0001", "0100"));
            Console.WriteLine("add : 0100 + 0100 = {0}", DigitalLogic.AddBinaryNumber("0100", "0100"));
            Console.WriteLine("add : 1111 + 1111 = {0}", DigitalLogic.AddBinaryNumber("1111", "1111"));

            Console.WriteLine("Number : {0}", ArithmeticLogic.ATOI("1231"));
            Console.WriteLine("Number : {0}", ArithmeticLogic.ATOI("-1231"));
            Console.WriteLine("Number : {0}", ArithmeticLogic.ATOI("-12a31"));
            Console.WriteLine("Number : {0}", ArithmeticLogic.ATOI("9999999999"));
            Console.WriteLine("Number : {0}", ArithmeticLogic.ATOI("-9999999999"));


            Console.WriteLine("Ip Address validation : {0}", StringLogic.isValidIp4(null));
            Console.WriteLine("Ip Address validation : {0}", StringLogic.isValidIp4("..."));
            Console.WriteLine("Ip Address validation : {0}", StringLogic.isValidIp4("000.0000.000.0000"));
            Console.WriteLine("Ip Address validation : {0}", StringLogic.isValidIp4("aa.0000.000.0000"));
            Console.WriteLine("Ip Address validation : {0}", StringLogic.isValidIp4("aa.00.00.000.0000"));
            Console.WriteLine("Ip Address validation : {0}", StringLogic.isValidIp4("172.0aa.0.0"));
            Console.WriteLine("Ip Address validation : {0}", StringLogic.isValidIp4("0...0"));
            Console.WriteLine("Ip Address validation : {0}", StringLogic.isValidIp4("0000...0"));
            Console.WriteLine("Ip Address validation : {0}", StringLogic.isValidIp4("172.0.0.00000"));
            Console.WriteLine("Ip Address validation : {0}", StringLogic.isValidIp4("172.0.0.0"));


            Console.WriteLine("Remove char from string: {0}", StringLogic.RemoveCharFromString("a", "aaabcaabcdef"));
            Console.WriteLine("Remove char from string: {0}", StringLogic.RemoveCharFromString("abc", "aaabcaabcdef"));

            Console.WriteLine("find second largest number: {0}", ArrayLogic.FindSecondLargestElement(new int[] { 15, 2, 0, 4, 15 }));

            int[] array1 = ArrayLogic.ContinueDeleteElementFromArray(new int[] { 15, 2, 0, 4, 15 }, 3);

            List<int> listArray = ArrayLogic.MergeTwoListArray(new List<int>() { 3, 4, 4, 5, 6 }, new List<int>() { 1, 2, 7, 8 });

            Console.ReadLine();
        }
    }
}
