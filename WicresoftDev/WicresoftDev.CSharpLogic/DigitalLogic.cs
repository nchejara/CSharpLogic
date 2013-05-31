using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WicresoftDev.CSharpLogic
{
    public class DigitalLogic
    {
        public static string DecimalToBinary(int decimalNumber)
        {
            string result = string.Empty;
            int reminder = 0;
            while (decimalNumber > 0)
            {
                reminder = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                result = reminder.ToString() + result;
            }

            return result;
        }
        public static string DecimalToHexadecimal(int decimalNumber)
        {
            string result = string.Empty;
            int reminder = 0;

            while (decimalNumber > 0)
            {
                reminder = decimalNumber % 16;
                decimalNumber = decimalNumber / 16;
                if (reminder == 10)
                    result = "A" + result;
                else if (reminder == 11)
                    result = "B" + result;
                else if (reminder == 12)
                    result = "C" + result;
                else if (reminder == 13)
                    result = "D" + result;
                else if (reminder == 14)
                    result = "E" + result;
                else if (reminder == 15)
                    result = "F" + result;
                else
                    result = reminder.ToString() + result;
            }
            return result;
        }
        public static string DecimalToOctal(int decimalNumber)
        {
            string result = string.Empty;
            int reminder = 0;
            while (decimalNumber > 0)
            {
                reminder = decimalNumber % 8;
                decimalNumber = decimalNumber / 8;
                result = reminder.ToString() + result;
            }

            return result;
        }
        public static int OctalToDecimal(string octalNumber)
        {
            int decimalNumer = 0;
            int j = octalNumber.Length - 1;
            for (int i = 0; i < octalNumber.Length; i++)
            {
                decimalNumer += Convert.ToInt32(octalNumber[i].ToString()) * (int)Math.Pow(8, j);
                j--;
            }
            return decimalNumer;
        }
        public static int BinaryToDecimal(string binaryNumber)
        {
            int decimalNumer = 0;
            int j = binaryNumber.Length - 1;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                decimalNumer += Convert.ToInt32(binaryNumber[i].ToString()) * (int)Math.Pow(2, j);
                j--;
            }
            return decimalNumer;
        }
        public static string OctalToBinary(string octalNumber)
        {
            return DecimalToBinary(OctalToDecimal(octalNumber));
        }
        public static int CountDigitBinaryNumber(string bineryNumber, char BineryDigit)
        {

            int count = 0;
            for (int i = 0; i < bineryNumber.Length; i++)
            {
                if (bineryNumber[i] == BineryDigit)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Adding same length binary number
        /// </summary>
        /// <param name="binaryNum1">Binary number</param>
        /// <param name="binaryNum2">Binary number</param>
        /// <returns></returns>
        public static string AddBinaryNumber(string binaryNum1, string binaryNum2)
        {
            if(binaryNum1.Length != binaryNum2.Length)
                return "Both binary number should have the same length!";
            
            string result = string .Empty;
            int carry = 0;

            for(int i = binaryNum2.Length-1; i >= 0; i--)
            {
                int res = Convert.ToInt16(binaryNum1[i].ToString()) + Convert.ToInt16(binaryNum2[i].ToString()) + carry;

                if(res == 2)
                {
                    carry = 1;
                    result = result + "0";
                }
                else if (res  == 3)
                {
                    carry = 1;
                    result = result + "1";
                }
                else
                {
                   
                    result += res.ToString();
                    carry = 0;
                }
            }
            if (carry > 0)
                result += carry;


            result = StringLogic.Reverse(result); // reverse the result

            return result;
        }
    }
}
