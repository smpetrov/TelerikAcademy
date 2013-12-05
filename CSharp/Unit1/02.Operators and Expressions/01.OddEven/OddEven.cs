/*
 * Write an expression that checks if given integer is odd or even.
*/

using System;
class OddEven
{
    static void Main()
    {
        int x = 5;
        if ((x % 2) == 0)
        {
            Console.WriteLine("Integer is odd");
        }
        else
        {
            Console.WriteLine("Integer is even");
        }
    }
}
