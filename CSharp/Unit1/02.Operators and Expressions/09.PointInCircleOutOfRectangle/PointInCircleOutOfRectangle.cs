/*
 * Write an expression that checks for given point (x, y) 
 * if it is within the circle K( (1,1), 3) and out of 
 * the rectangle R(top=1, left=-1, width=6, height=2).
*/
using System;
class PointInCircleOutOfRectangle
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        bool boolInRectangle = ((x >= -1) && (x <= 5)) && ((y <= 1) && (y >= -1));
        bool boolInCircle = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 3;
        bool boolResult = (boolInRectangle == false) && (boolInCircle == true);
        Console.WriteLine("The point in the area /cirle - rectangle/ = {0}", boolResult);
    }
}
