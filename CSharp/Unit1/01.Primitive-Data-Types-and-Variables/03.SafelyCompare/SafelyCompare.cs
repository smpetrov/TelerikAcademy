/*
 * Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
 */
using System;
class SafelyCompare
{
    static void Main()
    {
        float a = 5.3F;
        float b = 6.01F;
        Console.WriteLine(a == b);

        float c = 5.00000001F;
        float d = 5.00000003F;
        Console.WriteLine(c == d);
    }
}
