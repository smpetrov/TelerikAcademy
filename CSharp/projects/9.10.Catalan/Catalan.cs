using System;

namespace loops
{
    class Catalan
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
        static double CatalanValue(int n)
        {
            double product = (double)(Facturial(n + 1) * Facturial(n));
            double result=(double)(Facturial(2*n)/product);
            return result;
        }
        static void Main()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Facturial(i));
                Console.WriteLine(CatalanValue(i));
            }
        }
    }
}
