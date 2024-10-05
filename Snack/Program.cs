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
			int x = 5, y = 5;
			//Console.WriteLine($"{x}, {y}");
			Console.SetCursorPosition(x, y);
			//char key;
			ConsoleKey symbol;
			do
			{
				
				//key = Console.ReadKey(true).KeyChar;
				symbol = Console.ReadKey(true).Key;
				//Console.WriteLine($"{(int)key}\t{key}");
				switch(symbol)
				{
					case ConsoleKey.W: y--; break;
					case ConsoleKey.A: x--; break;
					case ConsoleKey.S: y++; break;
					case ConsoleKey.D: x++; break;
				}
				Console.SetCursorPosition(x, y);
			} while (/*true*/symbol != ConsoleKey.Escape);
		}
	}
}
