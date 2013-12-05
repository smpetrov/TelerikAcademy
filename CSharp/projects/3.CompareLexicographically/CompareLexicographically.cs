using System;

namespace Arrays
{
    class CompareLexicographically
    {
        static void Main()
        {
            Console.Write("Input length of arrays: ");
            int lengthArray = int.Parse(Console.ReadLine());
            Console.WriteLine("Data first array :");
            char[] firstArray = new char[lengthArray];
            for (int i = 0; i < lengthArray; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Data second array :");
            char[] secondArray = new char[lengthArray];
            for (int i = 0; i < lengthArray; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Results :");
            for (int i = 0; i < lengthArray; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("{0} is bigger then {1}", firstArray[i], secondArray[i]);
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("{1} is bigger then {0}", firstArray[i], secondArray[i]);
                }
            }
        }
    }
}
