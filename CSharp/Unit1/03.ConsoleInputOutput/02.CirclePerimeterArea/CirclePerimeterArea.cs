/*
 * Write a program that reads the radius r of a circle and prints its 
 * perimeter and area.
*/
using System;
class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("Input radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter of circle = {0:0.00}",(2 * Math.PI * radius));
        Console.WriteLine("Area of circle = {0:0.00}",(Math.PI * radius * radius));
    }
}
