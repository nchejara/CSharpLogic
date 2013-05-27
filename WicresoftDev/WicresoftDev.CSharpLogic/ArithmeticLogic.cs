using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WicresoftDev.CSharpLogic
{
    public class ArithmeticLogic
    {
        public static int reverseNumber(int reverseNumber)
        {
            int reminder = 0;
            int rev = 0;

            while (reverseNumber > 0)
            {
                reminder = reverseNumber % 10;
                reverseNumber = reverseNumber / 10;
                rev = rev * 10 + reminder;
            }

            return rev;
        }
        /// <summary>
        /// Sum of digit
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        public static int SumOfDigit(int digit)
        {
            int reminder = 0;
            int sum = 0;

            while (digit > 0)
            {
                reminder = digit % 10;
                digit = digit / 10;
                sum = sum + reminder;
            }
            return sum;
        }

        /// <summary>
        /// Swap two number without using 3rd variable
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void SwapNumber(int num1, int num2)
        {
            Console.Write("Number 1 = {0} and Number 2 = {1}", num1, num2);
            Console.WriteLine("\n After Swap");

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.Write("Number 1 = {0} and Number 2 = {1}", num1, num2);
        }
    }
}
