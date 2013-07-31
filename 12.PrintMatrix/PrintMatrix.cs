//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix..

using System;

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Enter a value for N:\n=> ");
        int nValue = int.Parse(Console.ReadLine());

        if (nValue > 20)
        {
            Console.WriteLine("Error! Please try again!");
            Console.WriteLine("N have to be less than 20\n");
            Main();
        }
        else
        {
            for (int i = 0; i < nValue; i++)
            {
                Console.Write("| ");
                for (int j = 1 + i; j <= nValue + i; j++)
                {
                    Console.Write(j + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}