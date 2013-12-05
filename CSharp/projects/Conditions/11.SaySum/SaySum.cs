using System;


namespace Conditions
{
    class SaySum
    {
        static string say0to9(int value)
        {
            string txt="";
            switch (value)
            {
                case 0:
                    txt="zero";
                    break;
                case 1:
                    txt="one";
                    break;
                case 2:
                    txt="two";
                    break;
                case 3:
                    txt="three";
                    break;
                case 4:
                    txt="four";
                    break;
                case 5:
                    txt="five";
                    break;
                case 6:
                    txt="six";
                    break;
                case 7:
                    txt="seven";
                    break;
                case 8:
                    txt="eight";
                    break;
                case 9:
                    txt="nine";
                    break;
            }
            return txt;

        }
        static string say10to19(int value)
        {
            string txt="";
            switch (value)
            {
                case 10:
                    txt="ten";
                    break;
                case 11:
                    txt="eleven";
                    break;
                case 12:
                    txt="twelve";
                    break;
                case 13:
                    txt="thirteen";
                    break;
                case 14:
                    txt="fourteen";
                    break;
                case 15:
                    txt="fifteen";
                    break;
                case 16:
                    txt="sixteen";
                    break;
                case 17:
                    txt="seventeen";
                    break;
                case 18:
                    txt="eighteen";
                    break;
                case 19:
                    txt="nineteen";
                    break;
            }
            return txt;
        }
        static string say20to90(int value)
        {
            string txt="";
            switch (value)
            {
                case 20:
                    txt="twenty";
                    break;
                case 30:
                    txt="thirty";
                    break;
                case 40:
                    txt="fourty";
                    break;
                case 50:
                    txt="fifty";
                    break;
                case 60:
                    txt="sixty";
                    break;
                case 70:
                    txt="seventy";
                    break;
                case 80:
                    txt="eighty";
                    break;
                case 90:
                    txt="ninty";
                    break;
            }
            return txt;
        }
        static string say0to99(double value)
        {
            string txtValue = "";
            if ((value >= 0) && (value <=9))
            {
                txtValue=say0to9((int)value);
            }
            else if ((value >= 10) && (value <= 19))
            {
                txtValue=say10to19((int)value);
            }
            else
            {
                int decada = (int)value/10;
                string txt=say20to90(decada*10);
                int lastDigit = (int)value - decada*10;
                if (lastDigit != 0)
                {
                    txtValue=txt + " " + say0to9(lastDigit);
                }
                else
                {
                    txtValue=txt;
                }
            }
            return txtValue;
        }
        static string say100(double value)
        {
            string txtValue = "";
            if ((value >= 0) && (value <= 99))
            {
                txtValue=say0to99(value);
            }
            return txtValue;
        }
        static string say1000(double value)
        {
            string txtValue = "";
            string txt = "";
            int decada = (int)value / 100;
            if (decada != 0)
            {
                txt = say0to9(decada) + " hundred";
            }
            int lastTwoDigit = (int) value - decada * 100;
            return txtValue=txt + " " + say100(lastTwoDigit);
        }
        static string say1000000(double value)
        {
            string txtValue = "";
            string txt = "";
            int decada = (int)value / 1000;
            if (decada != 0)
            {
                txt = say1000(decada) + " thousand";
            }
            int lastThreeDigit = (int)value - decada * 1000;
            return txtValue=txt + " " + say1000(lastThreeDigit);
        }
        static string say1000000000(double value)
        {
            string txtValue = "";
            string txt = "";
            int decada = (int)value / 1000000;
            if (decada != 0)
            {
                txt = say1000(decada) + " million";
            }
            int lastSixDigit = (int)value - decada * 1000000;
            return txtValue = txt + " " + say1000000(lastSixDigit);
        }
        static string say1000000000000(double value)
        {
            string txtValue = "";
            string txt = "";
            long decada = (long)value / 1000000000;
            if (decada != 0)
            {
                txt = say1000(decada) + " billion";
            }
            long lastElevenDigit = (long)value - decada * 1000000000;
            return txtValue = txt + " " + say1000000000(lastElevenDigit);
        }
        static string say1000000000000000(double value)
        {
            string txtValue = "";
            string txt = "";
            long decada = (long)value / 1000000000000;
            if (decada != 0)
            {
                txt = say1000(decada) + " trillion";
            }
            long lastElevenDigit = (long)value - decada * 1000000000000;
            return txtValue = txt + " " + say1000000000000(lastElevenDigit);
        }
        static void Main()
        {
            double value;
            bool exit = false;
            while (!exit)
            {
                Console.Write("Input value:");
                value = double.Parse(Console.ReadLine());
                if (value == -1)
                {
                    return;
                }
                if ((value >= 0) && (value <= 99))
                {
                    Console.WriteLine(say100(value));
                }
                else if ((value >= 100) && (value <= 999))
                {
                    Console.WriteLine(say1000(value));
                }
                else if ((value >= 100) && (value <= 999999))
                {
                    Console.WriteLine(say1000000(value));
                }
                else if ((value >= 1000000) && (value <= 999999999))
                {
                    Console.WriteLine(say1000000000(value));
                }
                else if ((value >= 1000000000) && (value <= 999999999999))
                {
                    Console.WriteLine(say1000000000000(value));
                }
                else if ((value >= 1000000000000) && (value <= 999999999999999))
                {
                    Console.WriteLine(say1000000000000000(value));
                }
            }
        }
    }
}
