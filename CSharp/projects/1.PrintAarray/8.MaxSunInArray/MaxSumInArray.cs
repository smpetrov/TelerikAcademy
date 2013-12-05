using System;

namespace Arrays
{
    class MaxSumInArray
    {
        static void Main()
        {
            int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int startSec = 0;
            int lastSec = 0;
            int maxSum =0;
            int sum = 0;
            int begin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startSec = begin;
                    lastSec = i;
                }
                else if (sum < 0)
                {
                    sum = 0;
                    begin = i + 1; ;
                }
            }
            for (int i = startSec; i <=lastSec ; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
