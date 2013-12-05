using System;

namespace loops
{
    class PrintNDigit
    {
        static void Main()
        {
            Console.Write("Input end digit ");
            int digit = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i<= digit; i++)
            {
                sum = sum + i;
                Console.WriteLine(i);
            }
            Console.WriteLine("Sum is "+sum);
        }
    }
}
