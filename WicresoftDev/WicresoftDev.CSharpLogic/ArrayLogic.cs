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
                if (array1[array1Start] < array2[array2Start] )
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

        /// <summary>
        /// Merge two sorted array list ... .. .
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static List<int> MergeTwoListArray(List<int> array1, List<int> array2)
        {
            
            List<int> mergedArray = new List<int>();

            int array1Start = 0;
            int array2Start = 0;
            int mergedStart = 0;

            while ((array1Start < array1.Count) && (array2Start < array2.Count))
            {
                if (array1[array1Start] < array2[array2Start])
                {
                    mergedArray.Add(array1[array1Start]);
                    mergedStart++;
                    array1Start++;
                }
                else
                {
                    mergedArray.Add(array2[array2Start]);
                    mergedStart++;
                    array2Start++;
                }
            }

            while (array1Start < array1.Count)
            {
                mergedArray.Add(array1[array1Start]);
                mergedStart++;
                array1Start++;
            }

            while (array2Start < array2.Count)
            {
                mergedArray.Add(array2[array2Start]);
                mergedStart++;
                array2Start++;
            }
            return mergedArray;
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
        
        public static int[] ContinueDeleteElementFromArray(int[] array, int index)
        {
            int[] tempArray = new int[array.Length - 1];
            
            for (int i = 0; i < array.Length-1; i++)
            {
                if (i == index)
                    continue;
                tempArray[i] = array[i];
            }

            if(!(tempArray.Length < index))
                tempArray= ContinueDeleteElementFromArray(tempArray,index);

            return tempArray;

        }
    }
}
