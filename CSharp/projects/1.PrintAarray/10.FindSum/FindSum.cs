using System;

namespace Arrays
{
    class FindSum
    {
        static void Main()
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
            int sumCurrent = 0;
            int sum = 8;
            int beginSeq = 0;
            int endSeq = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    sumCurrent = 0;
                    for (int m = i; (m <= i + j) && (m<arr.Length); m++)
                    {
                        sumCurrent = sumCurrent + arr[m];
                        if (sumCurrent == sum)
                        {
                            beginSeq = i;
                            endSeq = i + j;
                            break;
                        }
                    }
                    if (beginSeq != 0)
                    {
                        break;
                    }
                }
                if (beginSeq != 0)
                {
                    break;
                }
            }
            if (beginSeq != 0)
            {
                Console.WriteLine("Sequence");
                for (int n = beginSeq; n <= endSeq; n++)
                {
                    Console.Write(arr[n] + " ");
                }
                Console.WriteLine();
                Console.WriteLine(beginSeq + " " + endSeq);
            }
        }
    }
}
