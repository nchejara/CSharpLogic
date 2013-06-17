using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WicresoftDev.CSharpLogic
{
    public class SortingLogic
    {
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

        public static int[] MergeSort(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }
            
            int middle = array.Length / 2;

            int[] leftArray = new int[middle];
            for (int i = 0; i < middle; i++)
            {
                leftArray[i] = array[i];
            }

            int[] rightArray = new int[array.Length - middle];
            for (int i = 0; i < array.Length - middle; i++)
            {
                rightArray[i] = array[i + middle];
            }

            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);

            int leftPtr = 0;
            int rightPtr = 0;

            int[] sorted = new int[array.Length];
            
            
            int k = 0;

            while ((leftPtr < leftArray.Length) && (leftPtr < rightArray.Length))
            {
                if (leftPtr < leftArray.Length)
                {
                    sorted[k++] = leftArray[leftPtr++];
                }
                else
                {
                    sorted[k++] = rightArray[rightPtr++];
                }
            }

            while (leftPtr < leftArray.Length)
            {
                sorted[k++] = leftArray[leftPtr++];
            }

            while (rightPtr < rightArray.Length)
            {
                sorted[k++] = rightArray[rightPtr++];
            }

            return sorted;
           
        }
        
    }
}
