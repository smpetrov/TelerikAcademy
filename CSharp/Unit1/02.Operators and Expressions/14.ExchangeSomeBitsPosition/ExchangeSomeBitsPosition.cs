/*
 *Write a program that exchanges bits {p, p+1, …, p+k-1) 
 *with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
*/
using System;
class ExchangeSomeBitsPosition
{
    static void Main()
    {
        Console.Write("Input value x:");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Input position to first area p:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Input position to second area q:");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Input nubers of bits k:");
        int k = int.Parse(Console.ReadLine());
        if ((p + k < q) && (q > p))
        {
            //създаване на маската
            string strMask = new string('1', k);
            //използваме mask като маска
            //00000000000000000000000000000111 = 7
            int mask = int.Parse(strMask);
            int maskPositionP = mask << p;
            int maskPositionQ = mask << q;
            //вземаме битовете то позиции 3,4,5 и 24,25,26
            int bitFromPosotionP = (x & maskPositionP) >> p;
            int bitFromPositionQ = (x & maskPositionQ) >> q;
            int exchangeBitToPositionP;
            int exchangeBitToPositionQ;
            //нулираме битовете на позиции 3,4,5 и 24,25,26
            x = x & (~maskPositionP);
            x = x & (~maskPositionQ);
            //разменяме битовете на позиции 3,4,5 и 24,25,26
            exchangeBitToPositionP = bitFromPositionQ << p;
            exchangeBitToPositionQ = bitFromPosotionP << q;
            x = x | exchangeBitToPositionP;
            x = x | exchangeBitToPositionQ;
            Console.WriteLine("After exchange bits 3,4,5 with 24,25,26 = " + x);
        }
        else
        {
            Console.WriteLine("Wrong input area");
        }
    }
}
