using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WicresoftDev.CSharpLogic
{
    public class StringLogic
    {
        //Reverse string
        public static string Reverse(string str)
        {
            string reverseString = string.Empty;
            for (int i = Length(str) - 1; i >= 0; i--)
            {
                reverseString += str[i];
            }
            return reverseString;
        }
        //Reverse string word by word
        public static string ReverseWordByWord(string str)
        {
            string reverseStr = string.Empty;
            str = Trim(str);
            int len = Length(str);
            string word = string.Empty;

            for (int i = 0; i <= len - 1; i++)
            {
                if (str[i] == ' ' || str[i] == '\n')
                {
                    reverseStr += Reverse(word);
                    if (str[i] == '\n')
                    {
                        reverseStr += '\n';
                    }
                    else
                    {
                        reverseStr += ' ';
                    }
                    word = "";
                }
                else
                {
                    word += str[i].ToString();
                }
            }

            reverseStr += Reverse(word);

            return reverseStr;
        }

        //Finding length without using in-build string function
        public static int Length(string str)
        {
            int length = 0;
            bool done = false;

            do
            {
                try
                {
                    char c = str[length];
                    length++;
                }
                catch (IndexOutOfRangeException)
                {
                    done = true;
                }
            } while (!done);

            return length;
        }

        //Count total number of line in given string
        public static int TotalLine(string str)
        {
            str = Trim(str);
            int len = Length(str);
            int countLine = 0;

            for (int i = 0; i < len - 1; i++)
            {
                if (str[i] == '\n')
                {
                    countLine++;
                }
            }
            return countLine + 1;
        }
        //Count total word in given string
        public static int TotalWord(string str)
        {
            str = Trim(str);
            int len = Length(str);
            int totalWord = 0;

            for (int i = 0; i < len - 1; i++)
            {
                if (str[i] == ' ')
                {
                    totalWord++;
                }
                if (str[i] == '\n')
                {
                    totalWord++;
                }
            }
            return totalWord + 1;
        }


        //Remove left and right space from given tring
        public static string Trim(string str)
        {
            str = LeftTrim(str);

            return RightTrim(str);
        }
        //Remove space from Left side give string
        public static string LeftTrim(string str)
        {
            string leftTrimStr = string.Empty;
            int len = Length(str);
            int count = 0;
            for (int i = 0; i < len - 1; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            for (int i = count; i < len - 1; i++)
            {
                leftTrimStr += str[i];
            }
            return leftTrimStr;
        }
        //Remove space from right side give string
        public static string RightTrim(string str)
        {
            string rightTrimStr = string.Empty;
            int len = Length(str);
            int count = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
                else
                {
                    break;
                }

            }
            for (int i = len - (count + 1); i >= 0; i--)
            {
                rightTrimStr += str[i];
            }
            return Reverse(rightTrimStr);
        }

        //Remove additional space which added unintented between 2 words
        public static string RemoveAdditionalSpace(string str)
        {
            str = Trim(str);
            int len = Length(str);
            string str1 = string.Empty;
            int count = 0;

            for (int i = 0; i < len; i++)
            {
                if (str[i] == ' ')
                {
                    str1 += str[i];
                    for (int j = i + 1; j < len; j++)
                    {
                        if (str[j] != ' ')
                        {
                            break;
                        }
                        else
                        {
                            count++;
                        }
                    }
                    i += count; // Add count value in  i variable so loop can skip those space
                    count = 0; // Set count equals to 0
                }
                else
                {
                    str1 += str[i];
                }
            }

            return str1;

        }

        //Remove duplicate char from given string(E.G. "aabbcc" or aaabbbbbcccc
        public static string RemoveDuplicateChar(string str)
        {

            str = Trim(str);
            int len = Length(str);
            string uniqueStr = string.Empty;
            int count = 0;

            for (int i = 0; i < len; i++)
            {
                uniqueStr += str[i];
                for (int j = i + 1; j < len; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }

                i += count;
                count = 0;
            }

            return uniqueStr;
        }


        /// <summary>
        /// Pick one by one char from one string and remove picked char from other string
        /// e.g.  str1 = abc and str2 = aaabcaabcdef
        /// result = bcbcdef
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string RemoveCharFromString(string str1, string str2)
        {
            if (str1 == null)
                return str2;

            if (str1 != null && str2 == null)
                return null;

            // Also check string is empty ...

            //str1 : pick one by one char and remove it from str2
            int str1Len = StringLogic.Length(str1);

            for (int i = 0; i < str1Len; i++)
            {
                for (int j = 0; j < StringLogic.Length(str2); j++)
                {
                    if (str2[j] == str1[i])
                    {
                        str2 = RemovedCharAt(str2, str1[i]);
                    }
                }
            }
            return str2;
        }

        /// <summary>
        /// Removed a char from the string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ch"></param>
        /// <returns></returns>
        public static string RemovedCharAt(string str, char ch)
        {
            int len = StringLogic.Length(str);
            string newStr = string.Empty;
            for (int i = 0; i < len; i++)
            {
                if (str[i] == ch)
                    continue;
                newStr += str[i];
            }
            return newStr;
        }

        /// <summary>
        /// Validate IP4 address which is in form of string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int isValidIp4(string str)
        {
            if (str == null)
                return 0;

            int len = StringLogic.Length(str);
            if (len > 16) // string length should be lessthan or equal to 16
                return 0;

            //This validation based on the function requirement
            if (str[0] == '.') // first char shouldn't be '.'
                return 0;

            int segValue = 0; // use to count each segment value
            int charCount = 0; // char count in the segment
            int segCount = 1; // count total segment

            for (int i = 0; i < len; i++)
            {
                if (str[i] == '.')
                {
                    // SegCount should be 4 not more then that
                    if (segCount++ > 4)
                        return 0;

                    //charCount should be 3 not more than that
                    if (charCount > 3 || charCount == 0) // zero condition is based on function requirement
                        return 0;

                    charCount = segValue = 0; // assign 0 for both charCount and segValue because we need to again count for other segment 
                    continue;

                }

                //Return 0 if string consist below 0 and above 9 digit (it means return 0 if value is other than [0-9]
                if (str[i] < '0' || str[i] > '9')
                    return 0;

                //check max value of segment
                if ((segValue = segValue * 10 + (str[i] - '0')) > 255)
                    return 0;

                charCount++;
            }

            if (segCount != 4)
                return 0;

            if (charCount > 3)
                return 0;


            return 1;
        }

        /// <summary>
        /// Get quoted word from given string
        /// input str = I am "Naren" Chejara and work in "Shanghai".
        /// Output = "Naren""Shanghai"
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetQuotedWordFromString(string str)
        {
            if (str == null || str == "")
                return "";

            string getQuotedWord = string.Empty;

            int start = 0;
            int i = 0;
            int len = Length(str);

            while (i != len)
            {
                if (str[i] == '"')
                {
                    start = 0;
                    i++;
                    // initiliazed start with 1 if string contain end quote after quote started.
                    for (int j = i; j < len; j++)
                    {
                        if (str[j] == '"')
                        {
                            start = 1;
                        }

                    }
                    // get the work until we are not find end quote based on start flag
                    while (str[i] != '"' && start == 1 && i < len)
                    {
                        getQuotedWord += str[i];
                        if(i < len) // avoid OutOfIndex Exception
                            i++;
                    }
                    
                }
                if (i < len)// avoid OutOfIndex Exception
                    i++;
            }

            return getQuotedWord;
        }

        /// <summary>
        /// Get quoted word from given string
        /// input str = I am "Naren" Chejara and work in "Shanghai".
        /// Output = 2
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int CountQuotedWordFromString(string str)
        {
            if (str == null || str == "")
                return 0;

            int countQuotedWord = 0;
            int i = 0;
            int len = Length(str);

            while (i != len)
            {
                if (str[i] == '"')
                {
                    i++;
                    while (i != len)
                    {
                        if (str[i] == '"')
                        {
                            countQuotedWord++;
                            break;
                        }
                        if(i < len)
                            i++;
                    }

                }
                if (i < len)
                    i++;
            }

            return countQuotedWord;
        }


    }


}
