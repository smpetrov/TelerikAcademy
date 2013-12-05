/*
 * A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company 
 * and its manager and prints them on the console.
*/
using System;
class CompanyAndManagerInfo
{
    static void Main()
    {
        Console.Write("Input the company's name : ");
        string companyName = Console.ReadLine();
        Console.Write("Input the company's address : ");
        string  companyAddress= Console.ReadLine();
        Console.Write("Input the company's phone number : ");
        string  companyPhoneNumber = Console.ReadLine();
        Console.Write("Input the company's fax number : ");
        string  companyFaxNumber= Console.ReadLine();
        Console.Write("Input the company's web site : ");
        string  companyWebSite= Console.ReadLine();
        Console.Write("Input the company's manager first name: ");
        string  managerFistName= Console.ReadLine();
        Console.Write("Input the company's manager last name : ");
        string  managerLastNmae= Console.ReadLine();
        Console.Write("Input the ages of the manager : ");
        string  managerAges= Console.ReadLine();
        Console.Write("Input the phone number of the manager : ");
        string  managerPhoneNumber= Console.ReadLine();
        Console.WriteLine("Conmany : " + companyName);
        Console.WriteLine("Address : " + companyAddress);
        Console.WriteLine("Phone   : " + companyPhoneNumber);
        Console.WriteLine("Fax     : " + companyFaxNumber);
        Console.WriteLine("Web site: " + companyWebSite);
        Console.WriteLine("Manager : " + managerFistName + " " + managerLastNmae);
        Console.WriteLine("The manager is {0} years old.",managerAges);
        Console.WriteLine("The manager's phone : " + managerPhoneNumber);
    }
}
