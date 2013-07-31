////Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        Console.Write("Enter a value for N:\n=> ");
        int nValue = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for K:\n=> ");
        int kValue = int.Parse(Console.ReadLine());
        BigInteger result = 1;
        if (nValue > kValue)
        {
            for (BigInteger i = kValue + 1; i < nValue; i++)
            {
                result *= i;
                Console.WriteLine(result);
            }
        }
        else
        {
            Console.WriteLine("Error! N have to be greater than K!");
            Console.WriteLine("Try Again.");
            Main();
        }
    }
}