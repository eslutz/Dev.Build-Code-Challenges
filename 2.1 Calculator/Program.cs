using System;
using System.Collections.Generic;

namespace _2._1_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			LetsDoMath();
		}

		public static void LetsDoMath()
		{
			List<string> calculations = new List<string>();
			bool keepGoing = true;
			do
			{
				string output = MathTime();
				calculations.Add(output);
				Console.WriteLine(output);
			Repeat:
				Console.WriteLine("Would you like to do more math or see previous operations or quit (enter \"more\", \"previous\", or \"quit\") =>");
				string input = Console.ReadLine();
				switch (input)
				{
					case "more":
						break;
					case "previous":
						PrintPrevious(calculations);
						keepGoing = false;
						break;
					case "quit":
						keepGoing = false;
						break;
					default:
						Console.WriteLine("Invalid input");
						goto Repeat;
				}
			} while (keepGoing);
		}

		public static void PrintPrevious(List<string> previous)
		{
			for (int x = 0; x < previous.Count; x++)
			{
				Console.WriteLine(previous[x]);
			}
		}

		public static string MathTime()
		{
			double num1, num2;
			Console.WriteLine("Enter a number =>");
			num1 = GetNumberInput();
			Console.WriteLine("Enter a second number =>");
			num2 = GetNumberInput();
			Console.WriteLine("What type of math operation do you want to perform? (+, -, *, /) =>");
			string operation = GetOperationInput();
			return $"{num1} {operation} {num2} = {OutputMath(num1, num2, operation):N3}";

		}

		public static double GetNumberInput()
		{
			double number;
			bool isValidInput = double.TryParse(Console.ReadLine(), out number);
			while (!isValidInput)
			{
				Console.WriteLine("Invalid number. Try again =>");
				isValidInput = double.TryParse(Console.ReadLine(), out number);
			}
			return number;
		}

		public static string GetOperationInput()
		{
			string operation = Console.ReadLine();
			while (true)
			{
				switch (operation)
				{
					case "+":
						return operation;
					case "-":
						return operation;
					case "*":
						return operation;
					case "/":
						return operation;
					default:
						Console.WriteLine("Invalid operator. Try again (+, -, *, /) =>");
						operation = Console.ReadLine();
						continue;
				}
			}
		}

		public static double OutputMath(double num1, double num2, string operation)
		{
			switch (operation)
			{
				case "+":
					return num1 + num2;
				case "-":
					return num1 - num2;
				case "*":
					return num1 * num2;
				case "/":
					return num1 / num2;
				default:
					Console.WriteLine("Something happened...");
					return 0;
			}
		}
	}
}