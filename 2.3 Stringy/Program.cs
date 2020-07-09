using System;

namespace _2._3_Stringy
{
	class Program
	{
		private static char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };

		public static void Main(string[] args)
		{
			Console.WriteLine("Enter a word =>");
			string word = Console.ReadLine();
			Console.Write($"The word {word} backwards is {StringOne(word)} ");
			if (word == StringOne(word))
			{
				Console.WriteLine($"and is a palindrome.");
			}
			else
			{
				Console.WriteLine($"and is not a palindrome.");
			}
			Console.WriteLine($"There are {StringTwo(word)} vowel(s) in the word {word}.");
			Console.WriteLine($"The Pig Latin verion of the word {word} is {StringThree(word)}");
			Console.WriteLine("Enter a sentence =>");
			word = Console.ReadLine();
			Console.WriteLine($"There are {StringFour(word)} words in the sentence \"{word}\"");
		}

		public static string StringOne(string word)
		{
			string backwardString = "";
			for (int x = word.Length - 1; x >= 0; x--)
			{
				backwardString += word[x];
			}
			return backwardString;
		}

		public static int StringTwo(string word)
		{
			int vowelCount = 0;
			word = word.ToUpper();
			for (int x = 0; x < vowels.Length; x++)
			{
				for (int y = 0; y < word.Length; y++)
					if (vowels[x] == word[y])
					{
						vowelCount++;
					}
			}
			return vowelCount;
		}

		public static string StringThree(string word)
		{
			string pigLatin = "";
			string temp = word.ToUpper();
			char[] consonants = new char[] { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'Y', 'V', 'W', 'X', 'Z' };
			for (int x = 0; x < consonants.Length; x++)
			{
				if (consonants[x] == temp[0])
				{
					for (int y = 0; y < consonants.Length; y++)
					{
						if (consonants[y] == temp[1])
						{
							for (int z = 2; z < word.Length; z++)
							{
								pigLatin += word[z];
							}
							pigLatin += word[0];
							pigLatin += word[1];
							pigLatin += "ay";
						}
					}
					for (int q = 0; q < vowels.Length; q++)
					{
						if (vowels[q] == temp[1])
						{
							for (int w = 1; w < word.Length; w++)
							{
								pigLatin += word[w];
							}
							pigLatin += word[0];
							pigLatin += "ay";
						}
					}
				}
				for (int v = 0; v < vowels.Length; v++)
				{
					if (vowels[v] == temp[0])
					{
						pigLatin = word;
						pigLatin += "way";
					}
				}
			}
			return pigLatin;
		}

		public static int StringFour(string word)
		{
			string[] separateWords = word.Split(' ');
			return separateWords.Length;
		}
	}
}