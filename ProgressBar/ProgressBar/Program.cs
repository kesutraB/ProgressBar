using System;
using System.Text;
using System.Threading;

namespace ProgressBar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.CursorVisible = false;

			//first type
			StepsAndDelayGeneration(out int x, out int y);
			PrintInfo(x, y);

			//second type
		}

		#region printing

		private static void PrintInfo(int x, int y)
		{
			for (int i = 0; i < x; i++)
			{
				Console.Write($"{i + 1}. step: ");
				Thread.Sleep(y);
				PrintProgressBar(i);

				Console.Write($" {i + 1}/{x} steps\n");
			}
		}

		private static void PrintProgressBar(int i)
		{
			for (int j = 0; j < (i + 1); j++)
				Console.Write("\u2593");
		}

		#endregion

		private static void StepsAndDelayGeneration(out int x, out int y)
		{
			Random random = new Random();
			x = random.Next(1, 25);
			y = random.Next(200, 500);
		}
	}
}
