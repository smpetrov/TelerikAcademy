/*
 * We are given integer number n, value v (v=0 or 1) and a position p. 
 * Write a sequence of operators that modifies n to hold 
 * the value v at the position p from the binary representation of n.
 *Example: n = 5 (00000101), p=3, v=1  13 (00001101)
 *n = 5 (00000101), p=2, v=0  1 (00000001)
*/
using System;
class Write0Or1AtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int result;
        if (v == 1)
        {
            result = n | mask;
            Console.WriteLine("n = " + n + "  p = " + p + " v = " + v + " => " + result);
        }
        else if (v == 0)
        {
            result = n & (~mask);
            Console.WriteLine("n = " + n + "  p = " + p + " v = " + v + " => " + result);
        }
        else
        {
            Console.WriteLine("Wrong v / 0 or 1/ !!!");
        }
    }
}
