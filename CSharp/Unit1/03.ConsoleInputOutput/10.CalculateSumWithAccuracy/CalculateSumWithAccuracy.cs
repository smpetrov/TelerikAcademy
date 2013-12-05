/*
 * Write a program to calculate the sum (with accuracy of 0.001): 
 * 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
*/
using System;
class CalculateSumWithAccuracy
{
    static void Main()
    {
        decimal sum = 1;
        int divider = 2;
        while ((1.0/divider) >= 0.001)
        {
            if (divider % 2 == 0)
            {
                sum = sum + 1.0m / divider;
            }
            else
            {
                sum = sum - 1.0m / divider;
            }
            divider++;
        }
        Console.WriteLine("Sum = " + Math.Round(sum ,3));
    }
}
