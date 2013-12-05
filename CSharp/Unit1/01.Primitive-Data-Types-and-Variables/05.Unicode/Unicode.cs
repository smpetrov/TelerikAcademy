/*
 * Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
 */
using System;
class Unicode
{
    static void Main()
    {
        char a = '\u0048';  //unicode 72
        char b = (char)0x48;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
