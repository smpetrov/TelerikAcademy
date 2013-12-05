using System;

namespace Arrays
{
    class SequenceOfIncreasing
    {
        static void Main()
        {
            int[] arr = { 2, 2, 3, 4, 5, 6 , 6 };
            int[,] arrSeq = new int[arr.Length, arr.Length];
            int rowIndex = 0;
            int colIndex = -1;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1]-1)
                {
                    colIndex++;
                    arrSeq[rowIndex, colIndex] = arr[i];
                    if (i == arr.Length - 2)
                    {
                        colIndex++;
                        arrSeq[rowIndex, colIndex] = arr[i+1];
                    }
                }
                else
                {
                    colIndex++;
                    arrSeq[rowIndex, colIndex] = arr[i];
                    rowIndex++;
                    colIndex = -1;
                }
            }
            int rowMaxIndex = 0;
            int colMaxIndex = 0;
            for (int i = 0; i < arrSeq.GetLength(0); i++)
            {
                for (int j = 0; j < arrSeq.GetLength(1); j++)
                {
                    Console.Write(arrSeq[i,j]+" ");
                    if (arrSeq[i,j] != 0)
                    {
                        rowMaxIndex=i;
                        colMaxIndex=j;
                    }
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i <= colMaxIndex; i++)
            {
                Console.Write(arrSeq[rowMaxIndex, i] + " ");
            }
            Console.WriteLine();
        }
    }
}
