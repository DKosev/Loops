//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class CardNames
{
    static void Main()
    {
        string[] cardName = {"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
        string[] suitName = { "Clubs", "Hearts", "Diamonds", "Spades" };

        Console.Write("Choose which deck you want to see:\nType 1 for Clubs\nType 2 for Hearts\nType 3 for Diamonds\nType 4 for Spades\n=> ");
        int inputOption = int.Parse(Console.ReadLine());

        switch (inputOption)
        {
            case 1:
                for (int l = 0; l < cardName.Length; l++)
                {
                    Console.WriteLine(cardName[l] + " of " + suitName[0]);
                }
                break;
            case 2:
                for (int l = 0; l < cardName.Length; l++)
                {
                    Console.WriteLine(cardName[l] + " of " + suitName[1]);
                }
                break;
            case 3:
                for (int l = 0; l < cardName.Length; l++)
                {
                    Console.WriteLine(cardName[l] + " of " + suitName[2]);
                }
                break;
            case 4:
                for (int l = 0; l < cardName.Length; l++)
                {
                    Console.WriteLine(cardName[l] + " of " + suitName[3]);
                }
                break;
        }
    }
}

