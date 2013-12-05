using System;

namespace loops
{
    class DigitalSquare
    {
        static void Main()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n-1; i++)
            {
                for (int j = 1+i; j <= n+i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
