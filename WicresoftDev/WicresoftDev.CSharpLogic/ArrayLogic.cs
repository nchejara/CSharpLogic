using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WicresoftDev.CSharpLogic
{
    public class ArrayLogic
    {
        /// <summary>
        /// Merge 2 sorted array into in one array ...
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static int[] MergeTwoArray(int[] array1, int[] array2)
        {
            array1 = SortingLogic.InsertSort(array1);
            array2 = SortingLogic.InsertSort(array2);

            int[] mergeArray = new int[array1.Length + array2.Length];
            int array1Start = 0;
            int array2Start = 0;
            int mergeArrayStart = 0;

            while ((array1Start < array1.Length) && (array2Start < array2.Length))
            {
                if (array1Start < array1.Length)
                {
                    mergeArray[mergeArrayStart] = array1[array1Start];
                    mergeArrayStart++;
                    array1Start++;
                }
                else
                {
                    mergeArray[mergeArrayStart] = array2[array2Start];
                    mergeArrayStart++;
                    array2Start++;
                }
            }

            while (array1Start < array1.Length)
            {
                mergeArray[mergeArrayStart] = array1[array1Start];
                mergeArrayStart++;
                array1Start++;
            }

            while (array2Start < array2.Length)
            {
                mergeArray[mergeArrayStart] = array2[array2Start];
                mergeArrayStart++;
                array2Start++;
            }
            return mergeArray;
        }

        
        public static int[] RemoveDuplicate(int[] array)
        {
            int count = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        array[j] = 0;
                        count++;
                    }

                }
            }
            int k = 0;
            int[] temp = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    temp[k] = array[i];
                    k++;
                }
            }

            return temp;

        }

        /// <summary>
        /// Remove duplicate element from the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] RemoveDuplicateElement(int[] array)
        {
            int count = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        array = RemoveAt(array, j);
                        count++;
                    }

                }
            }
            return array;

        }

        /// <summary>
        /// Remove specific index element from the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="indexAt"></param>
        /// <returns></returns>
        public static int[] RemoveAt(int[] array, int indexOf)
        {
            int[] temp = new int[array.Length - 1];

            for (int i = 0, j = 0; i < temp.Length; i++, j++)
            {
                if (i == indexOf)
                {
                    j++;
                }
                temp[i] = array[j];
            }

            return temp;
        }

        /// <summary>
        /// Find second largest element from an array ...
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int FindSecondLargestElement(int[] array)
        {
            int largestElement = 0;
            int secondLargestElement = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (largestElement < array[i])
                {
                    largestElement = array[i];
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] == largestElement)
                            continue;

                        if (secondLargestElement < array[j])
                            secondLargestElement = array[j];
                    }
                }
            }

            return secondLargestElement;
        }
    }
}
