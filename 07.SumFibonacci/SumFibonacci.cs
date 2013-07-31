//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … Each member of the Fibonacci sequence (except the              first two) is a sum of the previous two members. 

using System;
using System.Numerics;

class SumFibonacci
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to see from the Fibonacci sequence:\n=> ");
        int nValue = int.Parse(Console.ReadLine());
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger result = 0;
        BigInteger sum = 0;
        if (nValue <= 1)
        {
            Console.WriteLine("Error! The entered number have to be greater than 1!");
            Console.WriteLine("Please try again!\n");
            Main();
        }
        else
        {
            for (int i = 0; i < nValue; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
                sum += secondNumber;
                Console.Write("{0} ", result);
            }
            Console.WriteLine("\n\nSum of these numbers is: {0}", sum);

        }
    }
}
