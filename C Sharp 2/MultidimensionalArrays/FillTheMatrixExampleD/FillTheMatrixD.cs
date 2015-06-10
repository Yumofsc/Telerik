/* Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:   
        
       d)
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7       */

using System;
class FillTheMatrixD
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the matrix");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        string direction = "right";
        int currentRow = 0;
        int currentCol = 0;

        // Guideing the spiral
        for (int i = 1; i <= n*n; i++)
        {
            if (direction == "right" && (currentCol >= n || matrix[currentRow,currentCol] != 0))
            {
                currentCol--;
                currentRow++;
                direction = "down";
            }
            else if (direction == "down" && (currentRow >= n || matrix[currentRow,currentCol] != 0))
            {
                currentCol--;
                currentRow--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || matrix[currentRow,currentCol] != 0))
            {
                currentCol++;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || matrix[currentRow,currentCol] != 0))
            {
                currentCol++;
                currentRow++;
                direction = "right";

            }

            // Creating directions
            matrix[currentRow, currentCol] = i;

            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }

        //Print matrix
        Console.WriteLine("The spiral matrix: ");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,-3}",matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
