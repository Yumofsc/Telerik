//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result

using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? number = null;
        double? value = null;
        Console.WriteLine("The values are: !null{0}! and ?null{1}?",number, value);

        int? sumNumber = number + 5;
        double? sumValue = value + 5.5;
        Console.WriteLine("The new values are:", sumNumber + sumValue);




        //Create a program that assigns null values to an integer and to a double variable.
        //Try to print these variables at the console.
        //Try to add some number or the null literal to these variables and print the result.
    }
}

