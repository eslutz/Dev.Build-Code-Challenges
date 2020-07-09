using System;

namespace _1._2_Hotness
{
	class Program
	{
		static void Main(string[] args)
		{
			int temperature = GetUserInput();
			PrintTemp(temperature);

			Console.WriteLine($"You're converted temperature is {ConvertTemp(temperature)} degrees Celsius.");
		}

		public static int GetUserInput()
		{
			Console.WriteLine("Please enter a temperature to convert from Fahrenheit to Celsius =>");
			int temp;
			//validates user input is an integer
			bool isValidInput = int.TryParse(Console.ReadLine(), out temp);
			//asks user to enter a number until input is valid
			while (!isValidInput)
			{
				Console.WriteLine("Invalid input. Enter a temperature =>");
				isValidInput = int.TryParse(Console.ReadLine(), out temp);
			}
			return temp;
		}

		public static int ConvertTemp(int fahrenheit)
		{
			int celsius = (fahrenheit - 32) * 5 / 9;
			return celsius;
		}

		public static int ConvertKelvin(int celsius)
		{
			int kelvin = celsius + 273;
			return kelvin;
		}

		public static void PrintTemp(int temp)
		{
			int convertedTemp = ConvertTemp(temp);
			int convertedKelvin = ConvertKelvin(convertedTemp);
			if (convertedKelvin < 0)
			{
				Console.WriteLine("That is too cold to exist.");
			}
			else if (convertedTemp < 0)
			{
				Console.WriteLine("Brr, it's cold.");
			}
			else if (convertedTemp <= 10)
			{
				Console.WriteLine("You may need a Jacket.");
			}
			else if (convertedTemp <= 20)
			{
				Console.WriteLine("Phew, getting warm.");
			}
			else if (convertedTemp <= 30)
			{
				Console.WriteLine("Dress lightly, it's hot outside.");
			}
			else if (convertedTemp > 30)
			{
				Console.WriteLine("It's scorching today, stay inside and play video games with the windows open!");
			}
		}
	}
}