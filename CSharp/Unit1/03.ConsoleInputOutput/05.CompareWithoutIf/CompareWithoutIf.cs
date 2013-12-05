/*
 * Write a program that gets two numbers from the console and 
 * prints the greater of them. Don’t use if statements.
*/
using System;
class CompareWithoutIf
{
    static void Main()
    {
        Console.Write("Input first digit : ");
        int firstDigit = int.Parse(Console.ReadLine());
        Console.Write("Input second digit : ");
        int secondDigit = int.Parse(Console.ReadLine());
        Console.WriteLine("The greater digit is " + 
            ((firstDigit > secondDigit) ? firstDigit : secondDigit ));
    }
}
