using System;

namespace _2._2_Astrology
{
	class Program
	{
		private static int[] count = new int[12];

		public static void Main(string[] args)
		{
			bool keepGoing = true;
			while (keepGoing)
			{
				Count(Astrology());
				keepGoing = GoAgain();
			}
			PrintCount();
		}

		public static void PrintCount()
		{
			string[] signs = new string[] { "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces" };
			Console.WriteLine("Would you like to see how many times a sign appeared? (y/n) =>");
			while (true)
			{
				string answer = Console.ReadLine();
				answer = answer.ToLower();
				if (answer == "n" || answer == "no")
				{
					break;
				}
				else if (answer == "y" || answer == "yes")
				{
					for (int x = 0; x < 12; x++)
					{
						Console.WriteLine($"The sign {signs[x]} appeared {count[x]} times.");
					}
					break;
				}
				else
				{
					Console.WriteLine("Invalid input.");
				}
			}
		}

		public static void Count(string sign)
		{
			if (sign == "Aries")
			{
				count[0]++;
			}
			else if (sign == "Taurus")
			{
				count[1]++;
			}
			else if (sign == "Gemini")
			{
				count[2]++;
			}
			else if (sign == "Cancer")
			{
				count[3]++;
			}
			else if (sign == "Leo")
			{
				count[4]++;
			}
			else if (sign == "Virgo")
			{
				count[5]++;
			}
			else if (sign == "Libra")
			{
				count[6]++;
			}
			else if (sign == "Scorpio")
			{
				count[7]++;
			}
			else if (sign == "Sagittarius")
			{
				count[8]++;
			}
			else if (sign == "Capricorn")
			{
				count[9]++;
			}
			else if (sign == "Aquarius")
			{
				count[10]++;
			}
			else
			{
				count[11]++;
			}
		}

		public static bool GoAgain()
		{
			while (true)
			{
				Console.WriteLine("Would you like to go again? (y/n) =>");
				string goAgain = Console.ReadLine();
				goAgain = goAgain.ToLower();
				if (goAgain == "n" || goAgain == "no")
				{
					return false;
				}
				else if (goAgain == "y" || goAgain == "yes")
				{
					return true;
				}
				else
				{
					Console.WriteLine("Invalid input.");
				}
			}
		}

		public static string Astrology()
		{
			DateTime bday = new DateTime();
			bday = GetBirthday();
			string birthday = bday.ToShortDateString();
			string[] date = GetDate(birthday);
			string sign = GetSign(bday);
			string zodiac = GetChineseZodiac(date);
			Console.WriteLine($"You're sign is {sign} and your chinese zodiac is {zodiac}.");
			return sign;
		}

		public static DateTime GetBirthday()
		{
			Console.WriteLine("Please enter your birthday (ex:February 25 2002 or 2/25/02) =>");
			DateTime birthday = new DateTime();
			bool isValid = DateTime.TryParse(Console.ReadLine(), out birthday);
			while (!isValid)
			{
				Console.WriteLine("You have entered an incorrect value.");
				Console.WriteLine("Please enter your birthday (ex:February 25 2002 or 2/25/02) =>");
				isValid = DateTime.TryParse(Console.ReadLine(), out birthday);
			}
			return birthday;
		}

		public static string[] GetDate(string bday)
		{
			string[] date = bday.Split('/');
			return date;
		}

		public static string GetSign(DateTime date)
		{
			date = date.AddYears(2000 - date.Year);
			if (date.CompareTo(new DateTime(2000, 2, 19)) <= 0)
			{
				return "Aquarius";
			}
			else if (date.CompareTo(new DateTime(2000, 3, 19)) <= 0)
			{
				return "Pisces";
			}
			else if (date.CompareTo(new DateTime(2000, 4, 20)) <= 0)
			{
				return "Aries";
			}
			else if (date.CompareTo(new DateTime(2000, 5, 20)) <= 0)
			{
				return "Taurus";
			}
			else if (date.CompareTo(new DateTime(2000, 6, 21)) <= 0)
			{
				return "Gemini";
			}
			else if (date.CompareTo(new DateTime(2000, 7, 22)) <= 0)
			{
				return "Cancer";
			}
			else if (date.CompareTo(new DateTime(2000, 8, 23)) <= 0)
			{
				return "Leo";
			}
			else if (date.CompareTo(new DateTime(2000, 9, 21)) <= 0)
			{
				return "Virgo";
			}
			else if (date.CompareTo(new DateTime(2000, 10, 22)) <= 0)
			{
				return "Libra";
			}
			else if (date.CompareTo(new DateTime(2000, 11, 21)) <= 0)
			{
				return "Scorpio";
			}
			else if (date.CompareTo(new DateTime(2000, 12, 21)) <= 0)
			{
				return "Sagittarius";
			}
			else
			{
				return "Capricorn";
			}
		}

		public static string GetChineseZodiac(string[] date)
		{
			int birthYear = int.Parse(date[2]);
			if ((birthYear - 4) % 12 == 0)
			{
				return "Rat";
			}
			else if ((birthYear - 4) % 12 == 1)
			{
				return "Ox";
			}
			else if ((birthYear - 4) % 12 == 2)
			{
				return "Tiger";
			}
			else if ((birthYear - 4) % 12 == 3)
			{
				return "Rabbit";
			}
			else if ((birthYear - 4) % 12 == 4)
			{
				return "Dragon";
			}
			else if ((birthYear - 4) % 12 == 5)
			{
				return "Snake";
			}
			else if ((birthYear - 4) % 12 == 6)
			{
				return "Horse";
			}
			else if ((birthYear - 4) % 12 == 7)
			{
				return "Goat";
			}
			else if ((birthYear - 4) % 12 == 8)
			{
				return "Monkey";
			}
			else if ((birthYear - 4) % 12 == 9)
			{
				return "Rooster";
			}
			else if ((birthYear - 4) % 12 == 10)
			{
				return "Dog";
			}
			else
			{
				return "Pig";
			}
		}
	}
}