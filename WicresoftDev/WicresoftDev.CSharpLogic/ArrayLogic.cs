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
       
        
    }
}
