using System;

namespace loops
{
    class FactorialTrailingZeros
    {
        static long Facturial(int n)
        {
            // Calculate n! = 1 * 2 * ... * n
            long result = 1;
            while (true)
            {
                if (n == 1)
                    break;
                result *= n;
                n--;
            }
            return result;
        }
        static int Stepen(int digit, int stepen)
        {
            int result = 1;
            for (int i = 1; i <= stepen; i++)
            {
                result = result * digit;
            }
            return result;
        }
        static void Main()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int exponent = 0;
            int trailingZeros = 0; ;
            int division = 0;
            do
            {
                exponent++;
                division=n/Stepen(5,exponent);
                trailingZeros = trailingZeros + division;
            }
            while(division>1);
            //Console.WriteLine("Factorial: "+Facturial(n));
            Console.WriteLine("TrailingZero: "+trailingZeros);
        }
    }
}
