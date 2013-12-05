using System;

namespace Conditions
{
    class Bonus
    {
        static void Main()
        {
            Console.Write("Input digit[1...9]: ");
            string str = Console.ReadLine();
            if (str.Length == 1) 
            {
                switch (str)
                {
                    case "1":
                    case "2":
                    case "3":
                        Console.Write("Result: " + (int.Parse(str) * 10));
                        break;
                    case "4":
                    case "5":
                    case "6":
                        Console.Write("Result: " + (int.Parse(str) * 100));
                        break;
                    case "7":
                    case "8":
                    case "9":
                        Console.Write("Result: " + int.Parse(str) * 1000);
                        break;
                    default:
                        Console.Write("Error Input !!!");
                        break;
                }
            }
            else
            {
                Console.Write("Error str !!!");
            }
        }
    }
}
