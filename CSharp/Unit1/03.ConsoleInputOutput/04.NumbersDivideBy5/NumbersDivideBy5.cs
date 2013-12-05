/*
 * Write a program that reads two positive integer numbers and prints 
 * how many numbers p exist between them such that the reminder of 
 * the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
*/
using System;
class NumbersDivideBy5
{
    static void Main()
    {
        Console.Write("Input first digit : ");
        int firstDigit = int.Parse(Console.ReadLine());
        Console.Write("Input second digit : ");
        int secondDigit = int.Parse(Console.ReadLine());
        int numberDivided5 = 0;
        for (int i = firstDigit; i <= secondDigit; i++)
        {
            if ((i % 5) == 0)
            {
                numberDivided5++;
            }
        }
        Console.WriteLine("Number of digits divided by 5 without reminder is " + numberDivided5);
    }
}
