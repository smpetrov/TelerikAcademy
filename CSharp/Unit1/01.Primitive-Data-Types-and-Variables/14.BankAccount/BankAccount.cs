/*
 * A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
 * bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed 
 * to keep the information for a single bank account using the appropriate data types and descriptive names.
 */
using System;
class BankAccount
{
    static void Main()
    {
        string firstName;
        string middleName;
        string lastName;
        decimal balance = 1/3m; // = 123.45m;
        string bankName;
        string IBAN;
        string BICCode;
        string cadrNumber1;
        string cadrNumber2;
        string cadrNumber3;
        Console.WriteLine(balance);
        Console.WriteLine(balance + balance + balance + balance + balance + balance + 
            balance + balance + balance + balance);
    }
}
