using System;

namespace loops
{
    class SumStepen
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
        static int Stepen(int digit,int stepen)
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
            Console.Write("Input x: ");
            int x = int.Parse(Console.ReadLine());
            double sum = 1.0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + Facturial(i) / Stepen(x,i);

            }
            Console.WriteLine("Sum = "+sum);
        }
    }
}
