using System;
using System.Text;
using System.Threading;

namespace ProgressBar
{
	internal class Program
	{
		public const string divone = "\u2591";
		public const string divtwo = "\u2592";
		public const string divthree = "\u2593";
		public const int MaxX = 25;
		public const int MaxY = 500;
		public const int steps = 50;
		public const int delay = 100;

		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.CursorVisible = false;

			//first type
			ProgressBarTypeOne();
			Console.WriteLine("\n");

			//second type
			ProgressBarTypeTwo();
			
		}

		private static void ProgressBarTypeOne()
		{
			int x, y;
			RNG(out x,MaxX);
			RNG(out y, MaxY);
			PrintInfoOne(x, y);
			Console.Write("\nCompleted.");
		}

		private static void ProgressBarTypeTwo()
		{
			PrintCharacter(steps, divone);
			PrintInfoTwo();
			Console.Write("\nCompleted.");
		}

		#region ProgressBar type one

		private static void PrintInfoOne(int x, int y)
		{
			for (int i = 0; i < x; i++)
			{
				if (i < x / 3)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					PrintProgressBarOne(i);
				}
				else if (i < (x / 3) * 2)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					PrintProgressBarOne(i);
				}
				else if (i < x)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					PrintProgressBarOne(i);
				}
				Console.ResetColor();
				PrintSteps(i, x);
				Thread.Sleep(y);
			}
		}

		private static void PrintProgressBarOne(int i)
		{
			Console.CursorLeft = i;
			Console.Write(divthree);
		}

		private static void RNG(out int rnd, int value)
		{
			Random random = new Random();
			rnd = random.Next(value);
		}

		#endregion

		#region ProgressBar type two
		
		private static void PrintInfoTwo()
		{
			for (int i = 0; i < steps; i++)
			{
				Console.CursorLeft = steps + 1;
				PrintSteps(i, steps);
				Console.CursorLeft = i;
				if (i < steps / 3)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					PrintProgressBarTwo(i);
				}
				else if (i < (steps / 3) * 2)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					PrintProgressBarTwo(i);
				}
				else if (i < steps)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					PrintProgressBarTwo(i);
				}
				Console.ResetColor();
			}
		}

		private static void PrintProgressBarTwo(int i)
		{
			for (int j = 0; j < 2; j++)
			{
				if (j == 0)
					Console.Write(divthree);
				if (j == 1 && i != steps - 1)
					Console.Write(divtwo);
				Thread.Sleep(delay);
			}
		}
		#endregion

		#region UniversalPrinting

		private static void PrintSteps(int i, int stepcount)
		{
			Console.Write($"{i + 1}/{stepcount}");
		}

		private static void PrintCharacter(int charcount, string character)
		{
			for (int i = 0; i < charcount; i++)
			{
				Console.Write(character);
			}
		}

		#endregion
	}
}