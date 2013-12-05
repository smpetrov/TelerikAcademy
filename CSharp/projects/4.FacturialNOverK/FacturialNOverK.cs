using System;

namespace loops
{
    class FacturialNOverK
    {
        static int Facturial(int n)
        {
            // Calculate n! = 1 * 2 * ... * n
            int result = 1;
            while (true)
            {
                if (n == 1)
                    break;
                result *= n;
                n--;
            }
            return result;
        }
        static void Main()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input k: ");
            int k = int.Parse(Console.ReadLine());
            double valueProduct = 0.0;
            double valueDivision = 0.0;
            if ((n > 1) && (n < k) && (k > n))
            {
                valueProduct =(double) Facturial(n) / Facturial(k);
                Console.WriteLine("Facturial {0} = {1}",n,Facturial(n));
                Console.WriteLine("Facturial {0} = {1}", k, Facturial(k));
                Console.WriteLine("Result {0}!/{1}! = {2}",n,k,valueProduct);

                valueDivision = (double)(Facturial(n) * Facturial(k))/Facturial(k-n);
                Console.WriteLine("Result ({0}!*{1}!)/({1}-{0}!) = {2}", n, k, valueDivision);
            }
            else
            {
                Console.WriteLine("Error values");
            }
        }
    }
}
