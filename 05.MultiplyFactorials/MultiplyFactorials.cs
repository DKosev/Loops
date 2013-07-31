//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class MultiplyFactorials
{
    static void Main()
    {
        Console.Write("Enter a value for K:\n=> ");
        int kValue = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for N:\n=> ");
        int nValue = int.Parse(Console.ReadLine());
        BigInteger resultK = 1;
        BigInteger resultN = 1;
        BigInteger resultBoth = 1;

        if ((kValue > nValue) && (nValue > 1))
        {
            for (int i = 1; i <= nValue; i++)
            {
                resultN *= i;
            }
            for (int m = 1; m <= kValue; m++)
            {
                resultK *= m;
            }
            for (int n = 1; n <= (kValue - nValue); n++)
            {
                resultBoth *= n;
            }
            BigInteger finalCalculations = (resultN * resultK) / resultBoth;
            Console.WriteLine("The result is:\n=> {0}", finalCalculations);
        }
        else
        {
            Console.WriteLine("Error! K have to be greater than N and N > 1!");
            Console.WriteLine("Try Again.");
            Main();
        }
    }
}
