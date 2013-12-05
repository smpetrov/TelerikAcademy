/*
 *Write a program that exchanges bits 3, 4 and 5 
 *with bits 24, 25 and 26 of given 32-bit unsigned integer.
*/ 
using System;
class ExchangeBitsPosition
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        //използваме  7 като маска
        //00000000000000000000000000000111 = 7
        int mask = 7;
        int maskPosition3 = mask << 3;
        int maskPosition24 = mask << 24;
        //вземаме битовете то позиции 3,4,5 и 24,25,26
        int bitFromPosotion3 = (x & maskPosition3) >> 3;
        int bitFromPosition24 =(x & maskPosition24) >> 24;
        int exchangeBitToPosition3;
        int exchangeBitToPosition24;
        //нулираме битовете на позиции 3,4,5 и 24,25,26
        x = x & (~maskPosition3);
        x = x & (~maskPosition24);
        //разменяме битовете на позиции 3,4,5 и 24,25,26
        exchangeBitToPosition3 = bitFromPosition24 << 3;
        exchangeBitToPosition24 = bitFromPosotion3 << 24;
        x = x | exchangeBitToPosition3;
        x = x | exchangeBitToPosition24;
        Console.WriteLine("After exchange bits 3,4,5 with 24,25,26 = " + x);
    }
}
