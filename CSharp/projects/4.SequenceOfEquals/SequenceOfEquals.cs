using System;

namespace Arrays
{
    class SequenceOfEquals
    {
        static void Main()
        {
            //int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int[] arr = { 1, 1, 1, 2, 1, 3,1 , 3, 1, 1 };
            int maxValue = 0;
            int lengthSec = 1;
            int maxLengthSec = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    lengthSec++;
                    if (i==arr.Length-1)
                    {
                        if (maxLengthSec <=lengthSec)
                        {
                            maxLengthSec = lengthSec;
                            maxValue = arr[i - 1];
                            lengthSec = 1;
                        }
                    }
                }
                else
                {
                    if (maxLengthSec <= lengthSec)
                    {
                        maxLengthSec = lengthSec;
                        maxValue = arr[i - 1];
                        lengthSec=1;
                    }
                }
            }
            Console.WriteLine("{0} repeat {1} ",maxValue,maxLengthSec);
        }
    }
}
