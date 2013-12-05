using System;

namespace Conditions
{
    class OrderValue
    {
        static void Main()
        {
            Console.Write("Input first value:");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Input last value:");
            int lastValue = int.Parse(Console.ReadLine());
            Console.Write("Input Third value:");
            int thirdValue = int.Parse(Console.ReadLine());

            if (firstValue > lastValue)
            {
                if (firstValue >= thirdValue)
                {
                    if (lastValue > thirdValue)
                    {
                        Console.Write("Order is {0} {1} {2}", firstValue, lastValue, thirdValue);
                    }
                    else
                    {
                        Console.Write("Order is {0} {1} {2}", firstValue, thirdValue, lastValue);
                    }
                }
                else
                {
                    Console.Write("Order is {0} {1} {2}", thirdValue,firstValue,lastValue);
                }
            }
            else
            {
                if (lastValue >= thirdValue)
                {
                    if (firstValue > thirdValue)
                    {
                        Console.Write("Order is {0} {1} {2}", lastValue, firstValue, thirdValue);
                    }
                    else
                    {
                        Console.Write("Order is {0} {1} {2}", lastValue, thirdValue, firstValue);
                    }
                }
                else
                {
                    Console.Write("Order is {0} {1} {2}", thirdValue, lastValue, firstValue);
                }
            }
        }
    }
}
