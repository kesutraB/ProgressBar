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
			//ProgressBarTypeOne();
			Console.WriteLine();

			//second type
			ProgressBarTypeTwo();
			
		}

		private static void ProgressBarTypeOne()
		{
			RandomSteps(out int x);
			RandomDelay(out int y);
			PrintInfo(x, y);
		}

		private static void ProgressBarTypeTwo()
		{
			PrintCharacter(steps, divone);
			for (int i = 0; i < steps; i++)
			{
				Console.CursorLeft = steps + 1;
				PrintSteps(i, steps);
			}
		}

		#region ProgressBar type one

		private static void PrintInfo(int x, int y)
		{
			for (int i = 0; i < x; i++)
			{
				PrintProgressBar(i);
				PrintSteps(i, x);
				Thread.Sleep(y);
			}
		}

		private static void PrintProgressBar(int i)
		{
			Console.CursorLeft = i;
			Console.Write(divthree);
		}

		private static void RandomSteps(out int x)
		{
			Random random = new Random();
			x = random.Next(MaxX);
		}

		private static void RandomDelay(out int y)
		{
			Random random = new Random();
			y = random.Next(MaxY);
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