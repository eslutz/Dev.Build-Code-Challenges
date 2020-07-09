using System;

namespace _2._4_Hangman
{
	class Program
	{
		public static void Main(string[] args)
		{
			WouldYouLikeToPlayAGame();
		}

		public static void WouldYouLikeToPlayAGame()
		{
			Console.WriteLine("Let's play a game of hangman!");
			string theWord = InputWordVailidation();
			Console.WriteLine(Hangman(theWord));
		}

		public static string Hangman(string word)
		{
			string incorrectGuessedLetters = "", correctGuessedLetters = "";
			for (int x = 6; x > 0;)
			{
				Console.WriteLine("Player Two, guess a letter. =>");
				Console.WriteLine($"(You have {x} guesses left.)");
				char guess = InputCharacter();
				if (incorrectGuessedLetters.Contains(guess) || correctGuessedLetters.Contains(guess))
				{
					Console.WriteLine("You have already guess this letter. Try again.");
				}
				else if (word.Contains(guess))
				{
					Console.WriteLine("You guessed a correct letter!");
					correctGuessedLetters += guess;
				}
				else
				{
					Console.WriteLine($"The word does not contain the letter {guess}.");
					incorrectGuessedLetters += guess;
					x--;
				}
				string temp = "";
				foreach (char c in word)
				{
					if (!temp.Contains(c))
					{
						temp += c;
					}
				}
				if (temp.Length == correctGuessedLetters.Length)
				{
					return $"YOU WIN! You guessed the word {word}.";
				}
			}
			return "You are out of guesses. You Lose!";
		}

		public static char InputCharacter()
		{
			char letter = ' ';
			bool isValid = false;
			while (!isValid)
			{
				isValid = char.TryParse(Console.ReadLine(), out letter);
				if (Char.IsLetter(letter))
				{
					continue;
				}
				else
				{
					Console.WriteLine("You have not entered a valid letter. Try again.");
					isValid = false;
				}
			}
			return letter;
		}

		public static string InputWordVailidation()
		{
			while (true)
			{
				Console.WriteLine("Player One, enter a word. =>");
				string input = Console.ReadLine();
				bool invalidCharater = false;
				foreach (char c in input)
				{
					if (!Char.IsLetter(c))
					{
						invalidCharater = true;
					}
				}
				if (input.Contains(' '))
				{
					Console.WriteLine("Please enter only one word.");
				}
				else if (invalidCharater)
				{
					Console.WriteLine("You have entered an invalid charater in your word.");
				}
				else
				{
					return input;
				}
			}
		}
	}
}