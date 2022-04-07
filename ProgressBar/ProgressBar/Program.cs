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
			Random random = new Random();
			int x = random.Next(1, 25);
			int y = random.Next(200, 500);
			for (int i = 0; i < x; i++)
			{
				Console.Write($"{i + 1}. step: ");
				Thread.Sleep(y);
				for (int j = 0; j < (i + 1); j++)
				{
					Console.Write("\u2593");
				}
				Console.Write($" {i + 1}/{x} steps\n");

				//second type
			}
		}
	}
}
