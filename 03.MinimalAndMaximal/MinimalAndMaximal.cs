//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinimalAndMaximal
{
    static void Main()
    {
        Console.Write("Choose how many numbers you want to enter:\n=> ");
        int numbersQty = int.Parse(Console.ReadLine());
        Console.WriteLine(new String('-', 20));
        int minimalValue = int.MaxValue;
        int maximalValue = int.MinValue;

        for (int i = 1; i <= numbersQty; i++)
        {
            Console.WriteLine("Enter the {0} number:", i);
            Console.Write("=> ");
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber > maximalValue)
            {
                maximalValue = inputNumber;
            }
            else if (inputNumber < minimalValue)
            {
                minimalValue = inputNumber;
            }
        }
        Console.WriteLine("The Maximal of the entered numbers is: {0}", maximalValue);
        Console.WriteLine("The Minimal of the entered numbers is: {0}", minimalValue);
    }
}