/*
 * Write a boolean expression that returns if the bit at 
 * position p (counting from 0) in a given integer 
 * number v has value of 1. Example: v=5; p=1  false.
*/
using System;
class BitAtPosotionIs1
{
    static void Main()
    {
        int v = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        if ((v & mask) != 0)
        {
            Console.WriteLine("The " + p + " bit is 1");
        }
        else
        {
            Console.WriteLine("The " + p + " bit is 0");
        }
        //another way
        //int bit = v& mask
        //bit = bit >> p;
        //Console.WriteLine("The " + p + " bit is " + bit);
    }
}
