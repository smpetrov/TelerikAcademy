/*
 * Write a program that gets a number n and after that gets more n 
 * numbers and calculates and prints their sum. 
*/
using System;
class SunNAferNNumbers
{
    static void Main()
    {
        Console.Write("Input n : ");
        int n = int.Parse(Console.ReadLine());
        int currentDigit;
        long sum = 0;
        for (int j = 1; j <= 2; j++)
        {

            for (int i = 1; i <= n; i++)
            {
                Console.Write("From unit {0} input number {1} : ", j , i);
                currentDigit = int.Parse(Console.ReadLine());
                sum = sum + currentDigit;
            }
        }
        Console.WriteLine("Sum = " + sum);
    }
}
