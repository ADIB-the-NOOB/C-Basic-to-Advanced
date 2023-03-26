using System;
using OOP;

// System all the collections of classes like - Console
// This namespace is a collection of - Interfaces, Structs, enum and Delegates

class Program
{
    static void Main(string[] args)
    {
        string secretWord = "Adib";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 3; 
        bool outOfGuesses = false;

        while (secretWord != guess && !outOfGuesses)
        {
            if (guessCount < guessLimit)
            {
                Console.Write("Enter your guess: ");
                guess = Console.ReadLine();
                guessCount++;
            }
            else
            {
                outOfGuesses = true;
                Console.WriteLine("You cann't guess anymore");
            }   
        }
        Console.WriteLine("You Won");
    }
}