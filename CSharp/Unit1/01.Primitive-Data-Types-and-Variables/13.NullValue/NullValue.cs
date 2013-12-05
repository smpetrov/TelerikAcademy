/*
 *Create a program that assigns null values to an integer and to double variables. 
 *Try to print them on the console, try to add some values or the null literal to them and see the result.
 */
using System;
class NullValue
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = a + 5;
        b = b + 5.3;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
