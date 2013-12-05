/*
 * Declare  two integer variables and assign them with 5 and 10 and after that exchange their values
 */
using System;
class ExcangeValues
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;
        byte c;
        Console.WriteLine("a = " + a + " b = " + b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("a = " + a + " b = " + b);
    }
}
