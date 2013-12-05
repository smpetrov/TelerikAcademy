/*
 * Write a boolean expression that checks for given integer 
 * if it can be divided (without remainder) by 7 and 5 in the same time.
*/

using System;
class DivideWithoutRemainder
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        string result;
        if (((x % 7) == 0) && ((x % 5) == 0))
        {
            result = "can";
        }
        else
        {
            result = "can't";
        }
        Console.WriteLine("Integer " + x + " " + result + " be divided without remainder by 7 an 5 in the same time");
    }
}
