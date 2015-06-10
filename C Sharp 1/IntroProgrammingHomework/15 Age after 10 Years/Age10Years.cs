using System;

//Problem 15.* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

class AgeAfter10Years
{
    static void Main()
    {
        DateTime bDay = new DateTime(1988, 08, 21);
        DateTime nDay = DateTime.Now;
        int MyAge = nDay.Year - bDay.Year;
        Console.WriteLine("My Currect Age is " + MyAge);
        int fAge = MyAge + 10;
        Console.WriteLine("My future Age will be " + fAge);


    }
}

