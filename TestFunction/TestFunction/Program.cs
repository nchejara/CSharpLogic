using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(StringManipulation.Reverse("Naren"));
            //Console.WriteLine(StringManipulation.Trim("      N c\nM p\nKeshav     "));
            //Console.WriteLine(StringManipulation.LeftTrim("      N c\nM p\nKeshav     "));
            //Console.WriteLine(StringManipulation.RightTrim("      N c\nM p\nKeshav     "));
            //Console.WriteLine(StringManipulation.ReverseWordByWord("   I am Naren Chejara\nand you are kumar "));
            //Console.WriteLine("Total Line : {0} || TotalWord : {1}", StringManipulation.TotalLine("   I am Naren Chejara\nand you are kumar "), StringManipulation.TotalWord("   I am Naren Chejara\nand you are kumar "));
            //Console.WriteLine(StringManipulation.RemoveAdditionalSpace("   I      am     Naren    Chejara\nand      you     are    kumar "));
            //Console.WriteLine(StringManipulation.RemoveDuplicateChar("aabbccccccccccccccccc"));
            //Console.WriteLine(StringManipulation.RemoveDuplicateChar("aaabbbbbcccc"));
            //[To do]: Below line string not work.need to sort in asending order
             //Console.WriteLine(StringManipulation.RemoveDuplicateChar("abcabc"));

            // Linked List

            LinkedListManipulation llm = new LinkedListManipulation();
            Node nodeA = new Node();
            nodeA.data = "A";

            Node nodeB = new Node();
            nodeB.data = "B";

            Node nodeC = new Node();
            nodeC.data = "C";

            llm.AddNode(nodeA);
            llm.AddNode(nodeB); 
            llm.AddNode(nodeC);

            llm.printNodes();

            Console.ReadLine();
        }
    }
    
    
}

