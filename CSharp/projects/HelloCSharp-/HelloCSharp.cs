using System;

namespace CSharpIntroduction
{
    class HelloCSharp
    {
        static void Main()
        {
            Console.WriteLine("Svilen Petrov");
            Console.WriteLine("");

            Console.WriteLine("1");
            Console.WriteLine("101");
            Console.WriteLine("1001");
            Console.WriteLine("");

            DateTime time = DateTime.Now;
            string format = "yyyy MM d h:m";
            Console.WriteLine(time.ToString(format));
            Console.WriteLine("");

            Console.WriteLine(Math.Sqrt(123456));
            Console.WriteLine("");

            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("-"+i);
                }
            }
            Console.WriteLine(""); 

            Console.Write("Enter your age:");
            string inputAge = Console.ReadLine();
            if (inputAge.Equals(""))
            {
                throw new System.ArgumentException("Didn't input age!");
            }
            else
            {
                int age = int.Parse(inputAge);
                Console.WriteLine("My age after 10 years will be "+(age+10));
            }
        }
    }
}
