using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunction
{
    public class StringManipulation
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
        private static int Length(string str)
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
                    for(int j= i + 1; j < len; j++)
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
                    i += count; // Add count value in  i variable so look can skipp those space
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

        
    }


}
