// Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
using System;
class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please type: 1 for \"int\", 2 for \"double\" and 3 for \"string\"");
        string n = Console.ReadLine();

        switch (n)
        {
            case "1": Console.WriteLine("The Variable is \"int\".Please enter value:");
                int i = int.Parse(Console.ReadLine());
                int sumi = i + 1;
                Console.WriteLine("The result is : {0}", i);
                     break;
            case "2": Console.WriteLine("The Variable is \"double\".Please enter value:");
                     double d = double.Parse(Console.ReadLine());
                     double sumd = d + 1;
                     Console.WriteLine("The result is : {0}", sumd);
                     break;
            case "3": Console.WriteLine("The Variable is \"string\".Please enter statement:");
                     string s = Console.ReadLine();
                     Console.WriteLine("The result is : {0}*",s);
                     break;
            default: Console.WriteLine("You must type digits 1, 2 or 3");
                     break;
                

        }
    }
}