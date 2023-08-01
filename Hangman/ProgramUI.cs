using System.Data;
using Internal;
using System;
using system;

public class ProgramUI
{
    public static void Run()
    {
        Console.WriteLine("Welcome to Hangman!");

        HangmanWords selectedWord = (HangmanWords)new Random().Next(0, Enum.GetValues(typeof(HangmanWords)).Length);

        string wordToGuess = selectedWord.ToString().ToLower();
        string displayWord = new string('_', wordToGuess.Length);
        int attempts = 0;

        while (attempts > 0 && displayWord.Contains("_"))
        {
            Console.WriteLine("\nWord: " + displayWord);
            Console.WriteLine($"Attempts left: {attempts}");

            Console.Write("Guess a letter: ");
            char guess = Console.ReadLine().ToLower()[0];

            if (wordToGuess.Contains(guess))
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        displayWord = displayWord.Remove(i, 1).Insert(i, guess.ToString());
                    }
                }
            }
            else
            {
                attempts--;
                DrawHangman(attempts);
            }
        }

        if (!displayWord.Contains("_"))
        {
            Console.WriteLine("\nCongrats, you guessed the word! The word was: " + wordToGuess);
        }
        else
        {
            Console.WriteLine("\nSOrry, you've run out of attempts. The word was: " + wordToGuess);
        }
    }


}