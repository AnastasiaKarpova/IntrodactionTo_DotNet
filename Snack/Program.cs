using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snack
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int x = 5, y = 5;
			////Console.WriteLine($"{x}, {y}");
			//Console.SetCursorPosition(x, y);
			////char key;
			//ConsoleKey symbol;
			//do
			//{

			//	//key = Console.ReadKey(true).KeyChar;
			//	symbol = Console.ReadKey(true).Key;
			//	//Console.WriteLine($"{(int)key}\t{key}");
			//	switch(symbol)
			//	{
			//		case ConsoleKey.W: y--; break;
			//		case ConsoleKey.A: x--; break;
			//		case ConsoleKey.S: y++; break;
			//		case ConsoleKey.D: x++; break;
			//	}
			//	Console.SetCursorPosition(x, y);
			//} while (/*true*/symbol != ConsoleKey.Escape);

			Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
			
			Random rand = new Random();
			//int x = 10, y = 10;
			int x = rand.Next(Console.WindowWidth);
			int y = rand.Next(Console.WindowHeight);
			Console.CursorVisible = false;
			//char key;
			ConsoleKey key;
			do
			{
				Console.Clear();
				Console.SetCursorPosition(0, 0);
				Console.WriteLine($"X={x}\t Y = {y}");
				Console.SetCursorPosition(x, y);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine((char)2);
				//key = Console.ReadKey(true).KeyChar;
				key = Console.ReadKey(true).Key;
				//Console.WriteLine($"{(int)key}\t{key}");
				switch (key)
				{
					//case 'w': y--; break;
					//case 's': y++; break;
					//case 'a': x--; break;
					//case 'd': x++; break;
					case ConsoleKey.UpArrow:
					case ConsoleKey.W: y--; break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S: y++; break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A: x--; break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D: x++; break;
				}
				if (x == 0 || y == 0 || 
					x == Console.WindowWidth || 
					y == Console.WindowHeight) Console.Beep();

				if (x == 0) x = 1;
				if(x == Console.WindowWidth) x = Console.WindowWidth - 1;
				if (y == 0) y = 1;
				if (y == Console.WindowHeight) y = Console.WindowHeight - 1;
			} while (/*key != 27*/key != ConsoleKey.Escape);
		}
	}
}
