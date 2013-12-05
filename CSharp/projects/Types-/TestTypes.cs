using System;

namespace Types
{
    class TestTypes
    {
        static void Main()
        {
            sbyte mySbyte = -115;
            byte myByte = 97;
            ushort myUshort = 52130;
            short myShort = -10000;
            int myInt = 4825932;

            float floatFirst = 12.345F;
            float floatSecond = 3456.091F;
            double doubleFirst  = 34.567839023;
            double doubleSecond = 8923.1234857;

            string strFirstFloat;
            string strSecondFloat;
            float valueFirstFloat;
            float valueSecondFloat;
            float testFirstFloat = 5.00000001F;
            float testSecondFloat = 5.00000003F;
            Console.Write("Въведете първата float стойност:");
            strFirstFloat = Console.ReadLine();
            Console.Write("Въведете втората float стойност:");
            strSecondFloat = Console.ReadLine();
            valueFirstFloat= float.Parse(strFirstFloat);
            valueSecondFloat = float.Parse(strSecondFloat);
            bool resultatRound= (Math.Round(valueFirstFloat,6) == Math.Round(valueSecondFloat,6));
            bool resultat = valueFirstFloat == valueSecondFloat;
            bool resultatTest = testFirstFloat == testSecondFloat;
            bool resultatTestRound = (Math.Round(testFirstFloat, 6) == Math.Round(testSecondFloat, 6));
            Console.WriteLine("{0} == {1} is {2} with round !",valueFirstFloat,valueSecondFloat,resultatRound);
            Console.WriteLine("{0} == {1} is {2} without round !", valueFirstFloat, valueSecondFloat, resultat);
            Console.WriteLine("{0} == {1} is {2} with round !", testFirstFloat, testSecondFloat, resultatTestRound);
            Console.WriteLine("{0} == {1} is {2} without round !", testFirstFloat, testSecondFloat, resultatTest);
        }
    }
}
