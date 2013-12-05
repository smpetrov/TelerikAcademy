using System;

namespace Arrays
{
    class SortingArray
    {
        static void Main()
        {
            int[] arr = {2,5,4,7,8,12,4,12,789,34,22,55,11,565,77 };
            int minVal = 0;
            int minIndex = 0;
            int firstVal = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                minVal=arr[i];
                minIndex = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (minVal > arr[j])
                    {
                        minVal = arr[j];
                        minIndex = j;       }
                }
                firstVal = arr[i];
                arr[i] = minVal;
                arr[minIndex] = firstVal;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
