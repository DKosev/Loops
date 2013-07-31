//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;
using System.Numerics;

class SumFactorials
{
    static void Main()
    {
        Console.Write("Enter a value for N:\n=> ");
        int nValue = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for X:\n=> ");
        int xValue = int.Parse(Console.ReadLine());
        BigInteger resultN = 1;
        BigInteger resultX = 1;
        BigInteger resultBoth = 1;

        if ((nValue > xValue) && (xValue >= 1))
        {
            for (int j = 1; j <= nValue; j++)
            {
                resultN *= j;
                resultX *= xValue;
                resultBoth = resultBoth + (resultN / resultX);
            }
        }
        else
        {
            Console.WriteLine("Error! N have to be greater than X!");
            Console.WriteLine("Try Again.");
            Main();
        }
        Console.WriteLine("The result is: {0}", resultBoth);
    }
}
