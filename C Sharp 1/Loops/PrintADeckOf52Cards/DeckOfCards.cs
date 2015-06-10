//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
//Use 2 nested for-loops and a switch-case statement.

using System;
class DeckOfCards
{
    static void Main()
    {
        char s = '♠';
        char h = '♥';
        char d = '♦';
        char c = '♣';
        for (int i = 2; i <= 15; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10: Console.Write(i); break;

                    case 11: Console.Write("J");break;
                    case 12: Console.Write("J"); break;
                    case 13: Console.Write("Q"); break;
                    case 14: Console.Write("K"); break;
                    case 15: Console.Write("A"); break;
                } 
                switch (j)
                {
                    case 1: Console.Write(s+","); break;
                    case 2: Console.Write(h+","); break;
                    case 3: Console.Write(d+","); break;
                    case 4: Console.Write(c+",\n"); break;
                }
            }
        }
    }
}