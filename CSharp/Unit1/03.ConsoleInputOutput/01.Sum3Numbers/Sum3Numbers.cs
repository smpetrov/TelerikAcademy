/*
 * Write a program that reads 3 integer numbers from the console and prints their sum.
*/
using System;
class Sum3Numbers
{
    static void Main()
    {
        Console.Write("Input first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Input third number: ");
        int number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum = " + (number1+number2+number3));
    }
}
