using System;

namespace Conditions
{
    class CompateValue
    {
        static void Main()
        {
            Console.Write("Input first value:");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Input last value:");
            int lastValue = int.Parse(Console.ReadLine());
            int midlle;
            if (firstValue>lastValue)
            {
                midlle = lastValue;
                lastValue = firstValue;
                firstValue = midlle;
            }
            Console.Write(firstValue+"<=>"+lastValue);
        }
    }
}
