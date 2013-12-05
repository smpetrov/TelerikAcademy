using System;

namespace loops
{
    class SumNDigit
    {
        static void Main()
        {
            Console.Write("Input quantity of digits ");
            int digits = int.Parse(Console.ReadLine());
            int sum = 0;
            int minValue = 0;
            int maxValue = 0;
            int inputDigit;
            for (int i = 1; i <= digits; i++)
            {
                Console.Write("Input digit "+i+" = ");
                inputDigit = int.Parse(Console.ReadLine());
                if ((minValue>inputDigit) || (i==1))
                {
                    minValue=inputDigit;
                }
                if ((maxValue<inputDigit) || (i==1))
                {
                    maxValue=inputDigit;
                }
            }
            Console.WriteLine("Min is {0} Max is {1}",minValue,maxValue);
        }
    }
}
