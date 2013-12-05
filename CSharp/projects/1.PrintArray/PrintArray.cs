using System;

namespace Arrays
{
    class PrintArray
    {
        static void Main()
        {
            int[] array = new int[20];
            for (int i  = 0; i < 20; i++)
            {
                array[i] = i * 5;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
