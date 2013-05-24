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

            LinkedList llm = new LinkedList();
            
            llm.AddNode("A");
            llm.AddNode("B"); 
            llm.AddNode("C");
            llm.AddNode("D");
            llm.AddNode("E");

            llm.ShowListOfNode();
            Console.WriteLine("\nTotal Node are {0}", llm.size);

            Console.WriteLine("\n{0} Node is retrived!", llm.RetriveNode(1).Data);
            Console.WriteLine("\n{0} Node is retrived!", llm.RetriveNode("B").Data);

            Console.WriteLine("\n Node {0}", llm.DeleteNode(2) ? "is deleted!" : "is not deleted!");
            Console.WriteLine("\n Node {0}", llm.DeleteNode("C") ? "is deleted" : "is not deleted!");
            llm.ShowListOfNode();
            Console.WriteLine("\nTotal Node are {0}", llm.size);
            llm.AddNodeFirst("AA");
            llm.AddNodeFirst("AA");
            llm.AddNodeFirst("BB");
            llm.AddNodeFirst("CC");
            llm.ShowListOfNode();
            Console.WriteLine("\nTotal Node are {0}", llm.size);
            llm.AddNodeLast("AAA");
            llm.AddNodeLast("BBB");
            llm.AddNode("123", 2);
            llm.ShowListOfNode();
            Console.ReadLine();
        }
    }
    
    
}

