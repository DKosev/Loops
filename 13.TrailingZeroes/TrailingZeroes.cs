﻿//* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples: N = 10  N! = 3628800  2; N = 20  N! = 2432902008176640000  4; Does your program work for N = 50 000?; Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

using System;

class TrailingZeroes
{
    static void Main()
    {
        Console.Write("Enter a value for 'n':\n=> ");
        int nValue = int.Parse(Console.ReadLine());
        int divisor = 5;
        int counter = 0;

        do
        {
            counter += (nValue / divisor);
            divisor *= 5;
        }
        while (nValue <= divisor);

        Console.WriteLine("The entered number {0} has {1} trailing zeroes at the end.", nValue, counter);
    }
}