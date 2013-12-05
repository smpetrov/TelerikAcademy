using System;

namespace Conditions
{
    class NestedStatement
    {
        static void Main()
        {
            Console.Write("Input first value:");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Input last value:");
            int lastValue = int.Parse(Console.ReadLine());
            Console.Write("Input Third value:");
            int thirdValue = int.Parse(Console.ReadLine());
            if (firstValue>lastValue)
            {
                if (firstValue >= thirdValue)
                {
                    Console.Write("Biggester is " + firstValue);
                }
                else
                {
                    Console.Write("Biggester is " + thirdValue);
                }
            }
            else
            {
                if (lastValue >= thirdValue)
                {
                    Console.Write("Biggester is " + lastValue);
                }
                else
                {
                    Console.Write("Biggester is " + thirdValue);
                }
            }
        }
    }
}
