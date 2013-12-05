using System;

namespace Conditions
{
    class TextDigit
    {
        static void Main()
        {
            Console.Write("Input value:");
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 0:
                    Console.Write("Zero");
                    break;
                case 1:
                    Console.Write("One");
                    break;
                case 2:
                    Console.Write("Two");
                    break;
                case 3:
                    Console.Write("Three");
                    break;
                case 4:
                    Console.Write("Four");
                    break;
                case 5:
                    Console.Write("Five");
                    break;
                case 6:
                    Console.Write("Six");
                    break;
                case 7:
                    Console.Write("Seven");
                    break;
                case 8:
                    Console.Write("Eight");
                    break;
                case 9:
                    Console.Write("Nine");
                    break;
                default:
                    Console.Write("Not digit!!!");
                    break;
            }
        }
    }
}
