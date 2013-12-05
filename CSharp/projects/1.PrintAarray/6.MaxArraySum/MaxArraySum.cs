using System;

namespace Arrays
{
    class MaxArraySum
    {
        static void Main()
        {
            //Console.Write("Input n:");
            //int n = int.Parse(Console.ReadLine());
            int n = 10;
            int k = 3;
            //Console.Write("Input k:");
            //int k = int.Parse(Console.ReadLine());
            //Console.Write("Input array of n elements:");
            int[] arrK = new int[k];
            //int[] arrN = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            int maxSum = 0;
            int sum = 0;
            int index=0;
            int[] arrN={2,5,1,3,4,6,2,5,6,2};
            for (int i = 0; i < n-k+1; i++)
			{
                for (int m = i+1; m <=n-k+1; m++)
                {
                    for (int l = 0; l <=n - (k+m)+1; l++)
                    {
                        //if ((m+k)<n)
                        {
                            Console.Write(i);
                            for (int j = m; j < (m-1)+(k-1); j++)
                            {
                                Console.Write(j);
                                sum = sum + arrN[j];
                            }
                            sum = sum + arrN[i] + arrN[((m - 1) + (k - 1)) + l];
                            Console.WriteLine(((m - 1) + (k - 1)) + l + " " + sum);
                            if (maxSum < sum)
                            {
                                maxSum = sum;
                                index = 0;
                                arrK[index]=arrN[i];
                                for (int j = m; j < (m-1)+(k-1); j++)
                                {
                                    index++;
                                    arrK[index]=arrN[j];
                                }
                                index++;
                                arrK[index] = arrN[((m - 1) + (k - 1)) + l];
                            }
                            sum = 0;
                            index = 0;
                        }
                    }
                }
			}
            Console.WriteLine("Max array:"+maxSum);
            for (int i = 0; i < k; i++)
            {
                Console.Write(arrK[i]);
            }
            Console.WriteLine();
        }
    }
}
