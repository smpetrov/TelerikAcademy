/*
 * Write a program to print the first 100 members of the sequence of 
 * Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 * Редичата на Фибуначи започва се с 1 и 1, а всеки следващ член на редицата 
 * се получава като сума на предходните два
*/
using System;
class EquenceOfFibunacci
{
    static void Main()
    {
        //Console.Write("Input number: ");
        //int number = int.Parse(Console.ReadLine());
        int number = 100;
        ulong temporaryValue = 0;

        Console.WriteLine(0);
        ulong previousValue = 1;
        Console.WriteLine(1);
        ulong currentValue = 1;
        Console.WriteLine(1);
        for (int i = 1; i <= number - 3; i++)
        {
            Console.WriteLine(previousValue + currentValue);
            temporaryValue = previousValue;
            previousValue = currentValue;
            currentValue = temporaryValue + currentValue;
        }
    }
}
