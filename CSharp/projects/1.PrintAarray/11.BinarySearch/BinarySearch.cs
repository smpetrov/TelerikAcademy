using System;

namespace Arrays
{
    class BinarySearch
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int[] arr = {1,2,3,14,15,16,27,28,29,30,31,32,33,35,37,39,40 };
            int begin = 0;
            int end = arr.Length;
            int midle = 0;
            bool yes = false;
            for (int i = 0; i < 2*Math.Log(arr.Length)+1; i++)
            {

                if (((end - begin) % 2) == 0)
                {
                    midle = (begin + (end - begin) / 2);
                }
                else
                {
                    midle = (begin + (end - begin) / 2) + 1;
                }
                if (arr[midle] == key)
                {
                    yes = true;
                    break;
                }
                else
                {
                    if (arr[midle] > key)
                    {
                        end = midle;
                    }
                    else
                    {
                         begin= midle;
                    }
                }
            }
            if (yes == true)
            {
                Console.WriteLine(arr[midle]+" "+midle);
            }
        }
    }
}
