using System;

namespace loops
{
    class Fibonacci
    {
        static void Main()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int temporaryValue = 0;
            Console.WriteLine(0);
            int previousValue = 1;
            Console.WriteLine(1);
            int currentValue = 1;
            Console.WriteLine(1);
            for (int i = 1; i <= n-3; i++)
            {
                Console.WriteLine(previousValue+currentValue);
                temporaryValue = previousValue;
                previousValue=currentValue;
                currentValue = temporaryValue+currentValue;
            }
        }
    }
}
