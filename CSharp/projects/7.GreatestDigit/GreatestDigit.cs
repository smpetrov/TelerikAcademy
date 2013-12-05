using System;

namespace Conditions
{
    class GreatestDigit
    {
        static void Main()
        {
            Console.Write("Input first value:");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Input last value:");
            int lastValue = int.Parse(Console.ReadLine());
            Console.Write("Input Third value:");
            int thirdValue = int.Parse(Console.ReadLine());
            Console.Write("Input four value:");
            int fourValue = int.Parse(Console.ReadLine());
            Console.Write("Input five value:");
            int fiveValue = int.Parse(Console.ReadLine());
            int bigest=firstValue;
            if (bigest<lastValue)
            {
                bigest = lastValue;
            }
            if (bigest < thirdValue)
            {
                bigest = thirdValue;
            }
            if (bigest < fourValue)
            {
                bigest = fourValue;
            }
            if (bigest < fiveValue)
            {
                bigest = fiveValue;
            }
            Console.Write("Bigest is "+bigest);
        }
    }
}
