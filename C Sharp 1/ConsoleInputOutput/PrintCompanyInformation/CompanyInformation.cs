//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;
class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Please Enter company name:");
        string cName = Console.ReadLine();
        Console.WriteLine("Please Enter manager name:");
        string mName = Console.ReadLine();

        string address = "231 Al. Malinov, Sofia";
        string phone = "+359 888 55 55 555";
        string fax = "(no fax)";
        string web = "http://telerikacademy.com/";



        Console.WriteLine("\n{0}\nAddress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \nManager: {5} (age: 25, tel. +359 2 981 981))",
            cName, address, phone, fax, web, mName);
       
    }
}
