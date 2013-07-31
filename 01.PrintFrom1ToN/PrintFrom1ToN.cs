//Write a program that prints all the numbers from 1 to N.

using System;

class PrintFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter the last number of the sequence:\n=> ");
        int inputNumber = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 0; i < inputNumber; i++)
        {
            result++;
            Console.WriteLine(result);
        }
    }
}

