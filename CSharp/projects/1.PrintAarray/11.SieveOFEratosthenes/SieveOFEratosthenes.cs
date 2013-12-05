using System;

namespace Arrays
{
    class SieveOFEratosthenes
    {
        static void Main()
        {
            int maxValue = int.Parse(Console.ReadLine());
            int[] arr=new int[maxValue+1];
            for (int i = 2; i <= maxValue; i++)
            {
                arr[i] = i;
            }
            for (int n = 2; n <= maxValue; n++)
            {
                if (arr[n] != 0)
                {
                    for (int i = n + n; i <= maxValue; i = i + n)
                    {
                        arr[i] = 0;
                    }
                }
            }
            for (int i = 2; i <= maxValue; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
