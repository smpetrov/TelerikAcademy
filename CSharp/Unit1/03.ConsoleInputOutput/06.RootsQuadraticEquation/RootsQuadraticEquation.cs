/*
 * Write a program that reads the coefficients a, b and c of a 
 * quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
*/
using System;
class RootsQuadraticEquation
{
    static void Main()
    {
        Console.Write("Input a : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Input b : ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Input c : ");
        int c = int.Parse(Console.ReadLine());
        double Discriminant = b * b - 4 * a * c;
        if (Discriminant < 0)
        {
            Console.WriteLine("Quadratic equation dousn't have roots !");
        }
        else if (Discriminant == 0)
        {
            Console.WriteLine("Quadratic equation root =" + (-(b / (2 * a))));
        }
        else
        {
            Console.WriteLine("Quadratic equation root fist = " + 
                               ((b + Math.Sqrt(Discriminant)) / (2 * a)));
            Console.WriteLine("Quadratic equation root second = " + 
                               ((b - Math.Sqrt(Discriminant)) / (2 * a)));
        }
    }
}
