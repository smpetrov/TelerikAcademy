using System;

namespace loops
{
    class EuclidAlgoritam
    {
        static void Main()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input k: ");
            int k = int.Parse(Console.ReadLine());
            int min;
            int max;
            int difference;
            if (n >= k)
            {
                max = n;
                min = k;
            }
            else
            {
                max = k;
                min = n;
            }
            while (max != min)
            {
                difference = max - min;
                if (difference >= min)
                {
                    max = difference;
                }
                else
                {
                    max = min;
                    min = difference;
                }
            }
            Console.WriteLine("gcd =:"+ max);
        }
    }
}
