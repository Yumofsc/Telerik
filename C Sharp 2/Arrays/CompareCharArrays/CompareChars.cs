//Problem 3. Compare char arrays

//    Write a program that compares two char arrays lexicographically (letter by letter).


using System;
class CompareChars
{
    static void Main()
    {
        Console.WriteLine("Enter First word");
        char[] firstWord = Console.ReadLine().ToCharArray();
        
        Console.WriteLine("Enter Secound word");
        char[] secoundWord = Console.ReadLine().ToCharArray();

        string lexicFirst = string.Join(", ", firstWord);
        int leingh = Math.Min(firstWord.Length, secoundWord.Length);

        for (int i = 0; i < leingh; i++)
        {
            if (firstWord[i] > secoundWord[i])
            {
                lexicFirst = string.Join("", firstWord);
                break;
            }
        }
        Console.WriteLine("lexicographically : {0}", lexicFirst);
    }
}



