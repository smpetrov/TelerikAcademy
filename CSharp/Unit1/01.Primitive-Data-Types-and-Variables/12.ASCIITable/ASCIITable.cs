/*
 * Find online more information about ASCII (American Standard Code for Information Interchange) 
 * and write a program that prints the entire ASCII table of characters on the console.
 */
using System;
class ASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 256; i++)
        {
            if (i % 25 == 0)
            {
                Console.WriteLine((char)i);
            }
            else
            {
                Console.Write((char)i);
            }
        }
    }
}
