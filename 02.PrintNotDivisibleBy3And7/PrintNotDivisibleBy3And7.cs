//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class PrintNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter the last number of the sequence:\n=> ");
        int lastNumber = int.Parse(Console.ReadLine());

        for (int nextNumber = 0; nextNumber <= lastNumber; nextNumber++)
        {
            if ((nextNumber % 3 != 0) && (nextNumber % 7 != 0))
            {
                Console.WriteLine(nextNumber);
            }
        }
    }
}