/*
 * Write an expression that checks for given integer 
 * if its third digit (right-to-left) is 7. E. g. 1732  true.
*/
using System;
class ThirdDigit
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int result = (x / 100) % 10;
        if (result == 7)
        {
            Console.WriteLine("Third digit is 7");
        }
        else
        {
            Console.WriteLine("Third digit is not 7");
        }

        /* another way
        string b = Convert.ToString(x);
        Console.WriteLine(b[b.Length - 3].CompareTo('7') == 0);
         */
    }
}
