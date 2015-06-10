//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//Use descriptive names. Print the data at the console.

using System;
class EmployeeData
{
    static void Main()
    {
        string firstN = "Konstantin";
        string lastN = "Popov";
        byte age = 26;
        string sex = "m";
        ulong id = 8306112507;
        ulong emN = 27560543;
        Console.WriteLine("Bank employee:\n \nFirst name: {0} \nLast name: {1} \nAge: {2} \nGender: {3} \nPersonal ID number: {4} \nUnique employee number: {5}", firstN, lastN, age, sex, id, emN);
    }
}
