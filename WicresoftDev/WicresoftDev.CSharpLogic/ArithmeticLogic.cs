﻿using System;
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

        public static int ATOI(string str)
        {
            int sign = 1;
            int i = 0;
            int convertedNumber = 0;
            int len = StringLogic.Length(str);
            char[] temp = toCharArray(str);
            //Check whether number is positive or negative
            if (str[0] == '-')
            {
                sign = -1;
                i = 1;
            }
            for (; i < len; i++)
            {
                if (temp[i] >= '0' && temp[i] <= '9')
                {
                    convertedNumber = convertedNumber * 10 + (temp[i] - 48);
                }
                else
                {
                    return 0;
                }
            }

            return convertedNumber * sign;
        }

        public static char[] toCharArray(string str)
        {
            if (str == null)
                return null;

            int len = StringLogic.Length(str);
            char[] charArray = new char[len];

            for (int i = 0; i < len; i++)
            {
                charArray[i] = str[i];
            }

            return charArray;
        }

    }
}
