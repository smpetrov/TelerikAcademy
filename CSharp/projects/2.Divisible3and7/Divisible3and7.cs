using System;

namespace loops
{
    class Divisible3and7
    {
        static void Main()
        {
            Console.Write("Input end digit ");
            int digit = int.Parse(Console.ReadLine());
            for (int i = 1; i <= digit; i++)
            {
                if ((i%3 !=0) && (i%7 !=0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
