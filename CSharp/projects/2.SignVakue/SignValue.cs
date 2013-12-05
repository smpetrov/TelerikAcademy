using System;


namespace Conditions
{
    class SignValue
    {
        static void Main()
        {
            Console.Write("Input first value:");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Input last value:");
            int lastValue = int.Parse(Console.ReadLine());
            Console.Write("Input Third value:");
            int thirdValue = int.Parse(Console.ReadLine());
            if (firstValue*lastValue*thirdValue >= 0)
            {
                Console.Write("Product value sign is + !");
            }
            else
            {
                Console.Write("Product value sign is - !");
            }
        }
    }
}
