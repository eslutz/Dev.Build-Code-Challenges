using System;

namespace _1._1_Fizz_Buzz
{
	class Program
	{
		static void Main(string[] args)
		{
			FizzBuzz(GetWord());
		}

		public static string GetWord()
		{
			Console.WriteLine("Please enter a word =>");
			string word = Console.ReadLine();
			return word;
		}

		public static void FizzBuzz(string word)
		{
			string value = "";
			bool lower = true;
			for (int x = 1; x <= 100; x++)
			{
				if (x % 3 == 0 || x % 5 == 0 || x % 15 == 0)
				{
					value = ToFizzOrBuzz(x, word);
					if (lower)
					{
						value = value.ToLower();
						lower = false;
					}
					else
					{
						value = value.ToUpper();
						lower = true;
					}
				}
				else
				{
					value = x.ToString();
				}
				Console.WriteLine(value);
			}
		}

		public static string ToFizzOrBuzz(int value, string word)
		{
			string part1 = "", part2 = "";
			part1 = word.Substring(0, (word.Length / 2));
			part2 = word.Substring(word.Length / 2);
			if (value % 15 == 0)
			{
				return word;
			}
			if (value % 3 == 0)
			{
				return part1;
			}
			if (value % 5 == 0)
			{
				return part2;
			}
			else
			{
				return null;
			}
		}
	}
}
