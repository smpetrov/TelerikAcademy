/*
 * Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
 * Use Windows Character Map to find the Unicode code of the © symbol. 
 * Note: the © symbol may be displayed incorrectly.
 */
using System;
using System.Text;

class CopyrightSymbol
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char a='\u00a9';
        Console.WriteLine(" " + " " + " " + a);
        Console.WriteLine(" " +  " " + a + " " + a);
        Console.WriteLine(" " +  a + " " + " " + " " + a );
        Console.WriteLine(a + " " + a + " " + a + " " + a );
    }
}
