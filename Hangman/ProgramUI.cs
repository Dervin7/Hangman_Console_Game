using System;

namespace Hangman
{
    public class ProgramUI
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to my Hangman game!");

            HangmanWords selectedWord = (HangmanWords)new Random().Next(0, Enum.GetValues(typeof(HangmanWords)).Length);

            string wordToGuess = selectedWord.ToString().ToLower();
            string displayWord = new string('_', wordToGuess.Length);
            int attempts = 6;

            List<char> guessedLetters = new List<char>();

            while (attempts > 0 && displayWord.Contains("_"))
            {
                Console.WriteLine("\nWord: " + displayWord);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Attempts left: {attempts}");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Guess a letter: ");
                char guess = Console.ReadLine().ToLower()[0];

                if (guessedLetters.Contains(guess))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Oops! Letter already guessed, try a different letter!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                guessedLetters.Add(guess);

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
                    DrawHangman(attempts, selectedWord);
                }
            }

            if (!displayWord.Contains("_"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCongrats, you guessed the word! The word was: " + wordToGuess);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nSorry, you've run out of attempts. The word was: " + wordToGuess);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void DrawHangman(int attemptsLeft, HangmanWords selectedWord)
        {
            switch (attemptsLeft)
            {
                case 6:
                    Console.WriteLine("     _____");
                    Console.WriteLine("    |     |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("__________|");
                    break;
                case 5:
                    Console.WriteLine("     _____");
                    Console.WriteLine("    |     |");
                    Console.WriteLine("    O     |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("__________|");
                    break;
                case 4:
                    Console.WriteLine("     _____");
                    Console.WriteLine("    |     |");
                    Console.WriteLine("    O     |");
                    Console.WriteLine("    |     |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("__________|");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\nHint: Type of Rain Forest animal...");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.WriteLine("     _____");
                    Console.WriteLine("    |     |");
                    Console.WriteLine("    O     |");
                    Console.WriteLine("   /|     |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("__________|");
                    break;
                case 2:
                    Console.WriteLine("     _____");
                    Console.WriteLine("    |     |");
                    Console.WriteLine("    O     |");
                    Console.WriteLine("   /|\\    |");
                    Console.WriteLine("          |");
                    Console.WriteLine("          |");
                    Console.WriteLine("__________|");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Hint: {HangmanHints.GetHint(selectedWord)}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 1:
                    Console.WriteLine("     _____");
                    Console.WriteLine("    |     |");
                    Console.WriteLine("    O     |");
                    Console.WriteLine("   /|\\    |");
                    Console.WriteLine("   /      |");
                    Console.WriteLine("          |");
                    Console.WriteLine("__________|");
                    break;
                case 0:
                    Console.WriteLine("     _____");
                    Console.WriteLine("    |     |");
                    Console.WriteLine("    O     |");
                    Console.WriteLine("   /|\\    |");
                    Console.WriteLine("   / \\    |");
                    Console.WriteLine("          |");
                    Console.WriteLine("__________|");
                    break;
                default:
                    break;
            }
        }
    }
}