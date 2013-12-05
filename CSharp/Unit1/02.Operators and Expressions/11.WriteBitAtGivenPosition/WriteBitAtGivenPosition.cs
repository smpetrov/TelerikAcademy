/*
 * Write an expression that extracts from a given integer i 
 * the value of a given bit number b. Example: i=5; b=2  value=1.
*/
using System;
class WriteBitAtGivenPosition
{
    static void Main()
    {
        int i = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int bit = (i & mask) >> b;
        Console.WriteLine("The " + b + " bit is " + bit);
    }
}
