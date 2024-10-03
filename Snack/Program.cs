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
			char key;
			do
			{
				key = Console.ReadKey(true).KeyChar;
				Console.WriteLine($"{(int)key}\t{key}");
			} while (true);
		}
	}
}
