//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula: (2 * n)! / (n + 1)! * n!

using System;
using System.Numerics;

class CatalanFormula
{
    static void Main()
    {
        Console.Write("Enter the value for 'n':\n=> ");
        int nValue = int.Parse(Console.ReadLine());
        BigInteger factMultiply = 1;
        BigInteger factSum = 1;
        BigInteger factN = 1;

        if (nValue >= 0)
        {
            for (int i = 1; i <= (2 * nValue); i++)
            {
                factMultiply *= i;
            }
            for (int i = 1; i <= (nValue + 1); i++)
            {
                factSum *= i;
            }
            for (int i = 1; i <= nValue; i++)
			{
			    factN *= i;
			}

            BigInteger finalResult = (factMultiply / factSum) * factN;
            Console.WriteLine("(2 * {0})! / ({0} + 1)! * {0}! = {1}", nValue, finalResult);
        }
        else
        {
            Console.WriteLine("Error!");
            Console.WriteLine("Please enter a value greater or equal to zero!");
            Main();
        }
    }
}
