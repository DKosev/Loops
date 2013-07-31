//* Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

using System;

class SpiralNumbers
{
    static void Main()
    {
        Console.Write("Enter a value for N: (N < 20)\n=> ");
        int nValue = int.Parse(Console.ReadLine());

        if (nValue > 20)
        {
            Console.WriteLine("Error! Try Again!\nHint: N < 20\n");
            Main();
        }
        else
        {
            int[,] spiral = new int[nValue, nValue];
            string direction = "right";
            int row = 0;
            int collumn = 0;

            for (int i = 1; i <= nValue * nValue; i++)
            {
                spiral[row, collumn] = i;
                
                //Directions.
                if (direction == "right")
                {
                    collumn++;
                }
                else if (direction == "down")
                {
                    row++;
                }
                else if (direction == "left")
                {
                    collumn--;
                }
                else if (direction == "up")
                {
                    row--;
                }

                //Where to go when reach a direction.
                if (direction == "right" && (collumn >= nValue || spiral[row,collumn] != 0))
                {
                    direction = "down";
                    collumn--;
                    row++;
                }
                else if (direction == "down" && (row >= nValue || spiral[row, collumn] != 0))
                {
                    direction = "left";
                    row--;
                    collumn--;
                }
                else if (direction == "left" && (collumn < 0 || spiral[row, collumn] != 0))
                {
                    direction = "up";
                    row--;
                    collumn++;
                }
                else if (direction == "up" && (row < 0 || spiral[row, collumn] != 0))
                {
                    direction = "right";
                    row++;
                    collumn++;
                }
            }

            //Print the matrix
            for (int i = 0; i < nValue; i++)
            {
                for (int j = 0; j < nValue; j++)
                {
                    Console.Write(String.Format("{0,5}", spiral[i,j]));
                }
                Console.WriteLine();
            }
        }
    }
}
