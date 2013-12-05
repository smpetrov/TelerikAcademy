using System;

namespace loops
{
    class SquareAndSpiral
    {
        static void Main()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n+1,n+1];
            int start = 0;
            int width = n;
            int end = n - 1;
            int step = 0;
            while (width != 0)
            {
                for (int i = 1; i <= 4; i++)
                {
                    switch (i)
                    {
                        case 1:
                            for (int j = 1+start; j <= end + start; j++)
                            {
                                step++;
                                array[1+start, j] = step;
                            }
                            break;
                        case 2:
                            for (int j = 1 + start; j <= end + start; j++)
                            {
                                step++;
                                array[j, end + start + 1] = step;
                            }
                            break;
                        case 3:
                            for (int j = end + start + 1; j >= 2 + start; j--)
                            {
                                step++;
                                array[end + start + 1, j] = step;
                            }
                            break;
                        case 4:
                            for (int j = end + start + 1; j >= start+2; j--)
                            {
                                step++;
                                array[j, start+1] = step;
                            }
                            break;
                    }
                }
            width = width - 2;
            start++;
            end = width - 1;
            }

            for(int i=1; i<=n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0,4} ",array[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
