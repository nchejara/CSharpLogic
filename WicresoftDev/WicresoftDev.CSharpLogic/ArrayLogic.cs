using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WicresoftDev.CSharpLogic
{
    public class ArrayLogic
    {
        public static int[] MergeTwoArray(int[] array1, int[] array2)
        {
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
        /// <summary>
        /// Bubble sort (n-1 * n-1)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
        /// <summary>
        /// Selection sort : 
        /// 1. Find minmum number
        /// 2. Swap minimum number with first element
        /// 3. Repeat step 1 and 2 fromt the 2nd element onwards
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SelectionSort(int[] array)
        {
            int min = 0;

            for (int i = 0; i < array.Length; i++)
            {
                min = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                }

                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }

            return array;
        }
        /// <summary>
        /// Insert Sort :
        /// 
        /// 1. select two element from the left side and compare it
        /// 2. break inner loop if condition true
        /// 3. Repeat step 1-3
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] InsertSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        break;
                    }
                }
            }

            return array;
        }

        //public static int[] MergeSort(int[] array)
        //{
        //    int[] array1 = array;
        //    int leftIndex = 0;
        //    int rightIndex = array1.Length - 1;
        //    m_sort(ref array1, leftIndex, rightIndex);

        //    return array1;
        //}
        //private static void m_sort(ref int[] array, int leftIndex, int rightIndex)
        //{
        //    int mid = 0;
            
        //    if (rightIndex > leftIndex)
        //    {
        //        mid = (rightIndex + leftIndex) / 2;
        //        m_sort(ref array, leftIndex, mid);
        //        m_sort(ref array, mid + 1, rightIndex);
        //    }
            
        //}
        //private int[] MergeArray(int[] array)
        //{

        //}
        
    }
}
