//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = Convert.ToChar(i + 65);
        }
        Console.WriteLine("Enter word using capital letters: ");
        string word = Console.ReadLine();
        foreach (var letter in word)
        {
            Console.WriteLine("The letter {0} is on index: [{1}]", letter, (int)letter - 65);
        }
    }
}
