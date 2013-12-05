/*
 * Write an expression that calculates trapezoid's area by given 
 * sides a and b and height h.
 * /2.0 за да стане double резултата
*/
using System;
class TrapezoidArea
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine("Trapezoid's area is :" + ((a + b) * h / 2.0));
    }
}
