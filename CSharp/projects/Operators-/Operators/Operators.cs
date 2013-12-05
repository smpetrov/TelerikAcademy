using System;

namespace Operators
{
    class Operators
    {
        static void Main()
        {
            /*
            int a = 6;
            Console.WriteLine((a%2==0) ? "ood":"even");

            Console.WriteLine((a/5==0) && (a/77==0));

            int width = 3;
            int height = 5;
            Console.WriteLine("Rectangle's area is "+width*height);

            int c = 31723765;
            string b = Convert.ToString(c);
            Console.WriteLine(b[b.Length-3].CompareTo('7')==0);

            int d = 16;
            int resultMove = 1 << 3;
            int resultAnd = d & resultMove;
            int bit = resultAnd >> 3;
            Console.WriteLine("bit is {0} {1} ",bit,bit==1);

            int x = 4;
            int y = 5;
            Console.WriteLine((x<=5)&&(y<=5));

            Console.Write("Input value:");
            int value = int.Parse(Console.ReadLine());
            int endDivider = (int)Math.Sqrt(value);
            int divider=2;
            bool yesPrime = true;
            while (yesPrime && (divider<=endDivider))
            {
                if (value%divider==0)
                {
                    yesPrime = false;
                }
                divider++;
            }
            Console.WriteLine("Is {0} prime ? = {1}",value,yesPrime);
            

            Console.Write("Input a:");
            int aValue = int.Parse(Console.ReadLine());
            Console.Write("Input b:");
            int bValue = int.Parse(Console.ReadLine());
            Console.Write("Input h:");
            int hValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Area is"+(aValue+bValue)*hValue/2);
            
            Console.Write("Input x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input y:");
            int y = int.Parse(Console.ReadLine());
            bool boolInRectangle = ((x >= -1) && (x <= 5)) &&
                                   ((y <= 1) && (y >= -1));
            bool boolInCircle = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 3;
            bool boolResult=(boolInRectangle==false)&&
                            (boolInCircle==true);
            Console.WriteLine("In area cirle without rectangle {0}",boolResult );
            
            Console.Write("Input value v:");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Input position p:");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << (p-1);
            int result = v & mask;
            int bit = result >> (p-1);
 
            Console.Write("Input value n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input bit:");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Input position p:");
            int p = int.Parse(Console.ReadLine());
            int mask = (1 << (p - 1));
            int result=0;
            if (v == 1)
            {
                result = n | mask;
            }
            else
            {
                result = n & ~mask;
            }
            Console.WriteLine("Result:"+result);
            */

            Console.Write("Input value n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input from p bit:");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Input k bit exchange:");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Input to q bit:");
            int q = int.Parse(Console.ReadLine());
            char[] bitsBefore= new char[32];
            int i=31;
            while (n!=0)
            {
                bitsBefore[i] = (n & 1) == 1 ? '1' : '0';
                n=n>>1;
                i--;
            }
            for (int l =i; l>=0; l--)
            {
                bitsBefore[l]='0';
            };
            Console.WriteLine(bitsBefore);
            char bridge;
            for (int l =0 ; l<=k-1; l++ )
            {
                Console.WriteLine("{0} {1} {2} {3}",l,k,31-p-l,31-q-l);
                bridge = bitsBefore[31-p-l];
                bitsBefore[31-p-l] = bitsBefore[31-q-l];
                bitsBefore[31-q-l] = bridge;
                
            };
            Console.WriteLine(bitsBefore);
        }
    }
}
