/* Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as
sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix. */

using System;
class MatrixSequence
{                                           
    static void Main()
    {
        string[,] matrix = {
                      {"ha","fifi","ho","hi"},
                      {"fo","ha","hi","xx"},
                      {"xxx","ho","ha","xx"}
                           };
        int maxCounter = 1;
        int counter = 1;
        string longestSeq = "";
         
        // Horizontal search

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    longestSeq = matrix[row, col];
                }
            }
            counter = 1;
        }

        // Vertically search

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    counter++;
                }
                else
                    counter = 1;
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    longestSeq = matrix[row, col];
                }
            }
            counter = 1;
        }
        
        // Diagonal search
        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if (matrix[row,col] == matrix[row + 1, col + 1])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                longestSeq = matrix[row, col];
            }
        }
        Console.Write("The longest sequence of equal elements is: ");
        for (int i = 0; i < maxCounter; i++)
        {
            Console.Write("{0}, ",longestSeq);
        }
        Console.WriteLine();
    }
}

