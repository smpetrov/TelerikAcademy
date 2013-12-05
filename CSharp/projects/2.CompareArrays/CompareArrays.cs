using System;
namespace Arrays
{
    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Input length of first array: ");
            int lengthFirstArray = int.Parse(Console.ReadLine());
            int[] firstArray = new int[lengthFirstArray];
            for (int i =    0; i < lengthFirstArray; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());    
            }
            Console.Write("Input length of second array: ");
            int lengthSecondArray = int.Parse(Console.ReadLine());
            int[] secondArray = new int[lengthSecondArray];
            for (int i = 0; i < lengthSecondArray; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < lengthFirstArray; i++)
            {
                for (int j = 0; j <lengthSecondArray ; j++)
                {
                    Console.WriteLine("{0}= {1} is {2}",firstArray[i],secondArray[j],
                        firstArray[i]==secondArray[j]?true:false);
                }
            }
        }
    }
}
