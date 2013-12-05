/*
 * Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of 
 * the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable
 * (you should perform type casting).
 */
using System;
class SpringTypeCasting
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "world";
        object obj = str1 + " " + str2;
        string str3 = (string)obj;
        Console.WriteLine(obj);
        Console.WriteLine(str3);
    }
}
