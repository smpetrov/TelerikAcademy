using System;

namespace Conditions
{
    class ChoiceType
    {
        static void Main()
        {
            Console.Write("Coince input 1-integer, 3-double, 3-string: ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.Write("Input integer: ");
                    int choiceInt = int.Parse(Console.ReadLine());
                    Console.Write("Result: "+(choiceInt+1));
                    break;
                case 2:
                    Console.Write("Input double: ");
                    double choiceDouble = double.Parse(Console.ReadLine());
                    Console.Write("Result: "+(choiceDouble+1));
                    break;
                case 3:
                    Console.Write("Input string: ");
                    string choiceStr = Console.ReadLine();
                    Console.Write("Result: "+choiceStr+"*");
                    break;
                default:
                    Console.Write("Error Input !!!");
                    break;
            }
        }
    }
}
