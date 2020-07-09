using System;

namespace _1._3_Mad_Libs
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				string[] madLibWords = GetInput();
				MadLib(madLibWords);
				Console.WriteLine("Did you like your story, or would you like to try again (y/n) =>");
				char repeat;
				bool isValidInput = char.TryParse(Console.ReadLine(), out repeat);
				if (!(Char.ToLower(repeat) == 'y' || Char.ToLower(repeat) == 'n'))
				{
					isValidInput = false;
				}
				while (!isValidInput)
				{
					Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no =>");
					isValidInput = char.TryParse(Console.ReadLine(), out repeat);
					if (!(Char.ToLower(repeat) == 'y' || Char.ToLower(repeat) == 'n'))
					{
						isValidInput = false;
					}
				}
				if (repeat == 'n')
				{
					break;
				}
			}
		}

		public static string[] GetInput()
		{
			string[] input = new string[5];
			Console.WriteLine("Enter a name =>");
			input[0] = Console.ReadLine();
			Console.WriteLine("Enter a place =>");
			input[1] = Console.ReadLine();
			Console.WriteLine("Enter a verb =>");
			input[2] = Console.ReadLine();
			Console.WriteLine("Enter a adjective =>");
			input[3] = Console.ReadLine();
			Console.WriteLine("Enter a noun =>");
			input[4] = Console.ReadLine();
			return input;
		}

		public static void MadLib(string[] words)
		{
			Console.WriteLine($"There was a person named {words[0]}, from {words[1]}.  {words[0]} {words[2]} a {words[3]} {words[4]}.");
		}
	}
}