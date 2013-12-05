using System;


namespace Variables
{
    class DeclareVariable
    {
        static void Main()
        {
            int HexInt = 0x00FE;
            Console.WriteLine(HexInt);

            char char72v1 = '\u0072'; 
            char char72v2 = '\x0072';
            char char72v3 = '\u0048';
            char char72v4 = '\x0048';
            Console.WriteLine(char72v1);
            Console.WriteLine(char72v2);
            Console.WriteLine(char72v3);
            Console.WriteLine(char72v4);

            bool isFemale = false;

            string hello = "Hello";
            string world = "World";
            object textObject = hello + " " + world;
            string greeting = (string)textObject;
            Console.WriteLine(greeting);

            string textWithQuotes = "The \"use\" of quotations causes difficulties.";
            string textWithoutQuotes = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(textWithQuotes);
            Console.WriteLine(textWithoutQuotes);

            char copyright = '\x00A9';
            Console.WriteLine("  {0}", copyright);
            Console.WriteLine(" {0} {1}", copyright, copyright);
            Console.WriteLine("{0} {1} {2}", copyright, copyright, copyright); 

            string firstName;
            string familyName;
            byte age;
            char gender;
            uint IDNumber;
            uint employeeNumber;

            int value10 = 10;
            int value5 = 5;
            value10++;
            value5 = value5 + value10 + 10;


            for (int i = 1; i <= 127; i++)
            {
                if (i % 40 != 0)
                {
                    Console.Write((char)i + " ");
                }
                else
                {
                    Console.WriteLine((char)i + " \n");
                }
            }
            Console.WriteLine("\n");

            int? nullInt = null;
            double? nullDouble = null;
            nullInt = 100;
            nullDouble = 100.10;
            Console.WriteLine("This is int? {0}! This is double? {1}",nullInt,nullDouble);

            string fullName;
            decimal balance;
            string bankName;
            string IBAN;
            string bankBICCode;
            int cardVisa;
            int cardAmericanExpress;
            int cardMasterCard;
        }
    }
}
