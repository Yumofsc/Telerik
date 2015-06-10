/* Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
that has maximal sum of its elements. */

using System;
class MaximalSum
{
    static void Main()
    {
        //Console.WriteLine("Please enter number of rows in the matrix:");
        //int rows = int.Parse(Console.ReadLine());
        //Console.WriteLine("Please enter number of cols in the matrix:");
        //int cols = int.Parse(Console.ReadLine());
        //int[,] matrix = new int[rows, cols];
        int[,] matrix =
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 }
            };

        
        int maxSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestRow = row;
                    bestCol = col;

                }
            }
        }

        //printing the matrix
        Console.WriteLine("The best platform is:");
        Console.WriteLine("{0} {1} {2}", matrix[bestRow,bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow,bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1,bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1,bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2,bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2,bestCol + 2]);
        Console.WriteLine("The maximum sum is: {0}", maxSum);
    }
}
