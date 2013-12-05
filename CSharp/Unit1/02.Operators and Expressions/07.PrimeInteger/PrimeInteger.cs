/*
 * Write an expression that checks if given positive integer 
 * number n (n ≤ 100) is prime. E.g. 37 is prime.
 *От математиката се знае , че трябва да проверим дали 
 * някое от числата от 2 до корен квадратен от чеслото 
 * дели числото без остатък
*/
using System;
class PrimeInteger
{
    static void Main()
    {
        int value = int.Parse(Console.ReadLine());
        int endDivider = (int)Math.Sqrt(value);
        int divider = 2;
        bool yesPrime = true;
        while (yesPrime && (divider <= endDivider))
        {
            if (value % divider == 0)
            {
                yesPrime = false;
            }
            divider++;
        }
        Console.WriteLine("Is {0} prime ? = {1}", value, yesPrime);
    }
}
