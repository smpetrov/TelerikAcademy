/*
 * Write a boolean expression for finding if the bit 3 (counting from 0) 
 * of a given integer is 1 or 0.
*/
using System;
class WhatIsBit3
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        if ((x & mask) != 0)
        {
            Console.WriteLine("The third bit is 1");
        }
        else
        {
            Console.WriteLine("The third bit is 0");
        }

        /*another way
         *int d = 16;
         *int resultMove = 1 << 3;
         *int resultAnd = d & resultMove;
         *int bit = resultAnd >> 3;
         *Console.WriteLine("bit is {0} {1} ",bit,bit==1);
         */
    }
}
