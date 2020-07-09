using System;

namespace _1._4_RPS
{
	class Program
	{
		static void Main(string[] args)
		{
			RockPaperScisors();
		}

		public static void RockPaperScisors()
		{
			while (true)
			{
				string[] moves = new string[] { "rock", "paper", "scisors" };
				int move = GetInput() - 1;
				int computerMove = ComputerMove();
				Console.WriteLine($"You chose {moves[move]} and your opponent chose {moves[computerMove]}.");
				string didIWin = CompareMoves(move, computerMove);
				Console.WriteLine($"You {didIWin}!");
				if (!(didIWin == "Tie"))
				{
					break;
				}
			}
		}

		public static int GetInput()
		{
			Console.WriteLine("Enter your move! (1. rock, 2. paper, 3. scisors) =>");
			int input;
			bool isValidInput = int.TryParse(Console.ReadLine(), out input);
			if (input < 1 || input > 3)
			{
				isValidInput = false;
			}
			while (!isValidInput)
			{
				Console.WriteLine("Invalid input. Enter a number =>");
				isValidInput = int.TryParse(Console.ReadLine(), out input);
				if (input < 1 || input > 3)
				{
					isValidInput = false;
				}
			}
			return input;
		}

		public static int ComputerMove()
		{
			Random move = new Random();
			return move.Next(3);
		}

		public static string CompareMoves(int userMove, int computerMove)
		{
			string winOrLose = "";
			if (userMove == 0 && computerMove == 0)
			{
				winOrLose = "Tie";
			}
			if (userMove == 0 && computerMove == 1)
			{
				winOrLose = "Lose";
			}
			if (userMove == 0 && computerMove == 2)
			{
				winOrLose = "Win";
			}
			if (userMove == 1 && computerMove == 0)
			{
				winOrLose = "Win";
			}
			if (userMove == 1 && computerMove == 1)
			{
				winOrLose = "Tie";
			}
			if (userMove == 1 && computerMove == 2)
			{
				winOrLose = "Lose";
			}
			if (userMove == 2 && computerMove == 0)
			{
				winOrLose = "Lose";
			}
			if (userMove == 2 && computerMove == 1)
			{
				winOrLose = "Win";
			}
			if (userMove == 2 && computerMove == 2)
			{
				winOrLose = "Tie";
			}
			return winOrLose;
		}
	}
}