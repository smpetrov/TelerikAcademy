/*
 * Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
*/
using System;
class PointInCircle
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int radius = 5;
        if ((x*x + y*y)<radius*radius)
        {
            Console.WriteLine("Point (" + x + "," + y + ") is in the circle");
        }
        else
        {
            Console.WriteLine("Point (" + x + "," + y + ") is not in the circle");
        }
    }
}
