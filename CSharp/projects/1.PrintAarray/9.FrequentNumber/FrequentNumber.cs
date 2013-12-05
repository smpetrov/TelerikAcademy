using System;

namespace Arrays
{
    class FrequentNumber
    {
        static void Main()
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int mostFreguent = 0;
            int mostFrequentCell = 0;
            int currentFreguent = 0;
            for (int i = 0; i <arr.Length ; i++)
            {
                currentFreguent = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        currentFreguent++;
                    }
                }
                if (mostFreguent < currentFreguent)
                {
                    mostFreguent = currentFreguent;
                    mostFrequentCell = arr[i];
                }
            }
            Console.WriteLine(mostFrequentCell+" "+mostFreguent );
        }
    }
}
