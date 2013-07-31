//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter the first number:\n=> ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:\n=> ");
        int secondNumber = int.Parse(Console.ReadLine());

        if ((firstNumber <= 0) || (secondNumber <= 0) || (firstNumber == secondNumber))
        {
            Console.WriteLine("Error! Please try again!");
            Main();
        }
        else
        {
            if (firstNumber > secondNumber)
            {
                firstNumber = firstNumber - secondNumber;
            }
            else
            {
                secondNumber = secondNumber - firstNumber;
            }
            Console.WriteLine("The GCD is: {0}", firstNumber);
        }
    }
}
