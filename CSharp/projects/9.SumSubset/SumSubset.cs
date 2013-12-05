using System;

namespace Conditions{
    class SumSubset
    {
        static void Main()
        {
            Console.Write("Input first value:");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Input last value:");
            int v2 = int.Parse(Console.ReadLine());
            Console.Write("Input Third value:");
            int v3 = int.Parse(Console.ReadLine());
            Console.Write("Input four value:");
            int v4 = int.Parse(Console.ReadLine());
            Console.Write("Input five value:");
            int v5 = int.Parse(Console.ReadLine());
            if (v1 == 0) Console.Write("v1");
            if (v2 == 0) Console.Write("v2");
            if (v3 == 0) Console.Write("v3");
            if (v4 == 0) Console.Write("v4");
            if (v5 == 0) Console.Write("v5");
            if (v1 + v2 == 0) Console.Write("v1 v2");
            if (v1 + v3 == 0) Console.Write("v1 v3");
            if (v1 + v4 == 0) Console.Write("v1 v4");
            if (v1 + v5 == 0) Console.Write("v1 v5");
            if (v1 + v2 + v3 == 0) Console.Write("v1 v2 v3");
            if (v1 + v2 + v4 == 0) Console.Write("v1 v2 v4");
            if (v1 + v2 + v5 == 0) Console.Write("v1 v2 v5");
            if (v1 + v2 + v3 + v4 == 0) Console.Write("v1 v2 v3 v4");
            if (v1 + v2 + v3 + v5 == 0) Console.Write("v1 v2 v3 v5");
            if (v1 + v2 + v3 + v4 +v5 == 0) Console.Write("v1 v2 v3 v4 v5");
            if (v1 + v3 + v4 == 0) Console.Write("v1 v3 v4");
            if (v1 + v3 + v5 == 0) Console.Write("v1 v3 v5");
            if (v1 + v3 + v4 + v5 == 0) Console.Write("v1 v3 v4 v5");
            if (v1 + v4 + v5 == 0) Console.Write("v1 v4 v5");
            if (v2 + v3 == 0) Console.Write("v2 v3");
            if (v2 + v4 == 0) Console.Write("v2 v4");
            if (v2 + v5 == 0) Console.Write("v2 v5");
            if (v2 + v3 + v4 == 0) Console.Write("v2 v3 v4");
            if (v2 + v3 + v5 == 0) Console.Write("v2 v3 v5");
            if (v2 + v3 + v4 + v5 == 0) Console.Write("v2 v3 v4 v5");
            if (v3 + v4 == 0) Console.Write("v3 v4");
            if (v3 + v5 == 0) Console.Write("v3 v5");
            if (v3 + v4 + v5 == 0) Console.Write("v3 v4 v5");
            if (v4 + v5 == 0) Console.Write("v4 v5");

        }
    }
}
