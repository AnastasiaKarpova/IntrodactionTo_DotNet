using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static readonly string delimiter = "\n-----------------------------------------\n";
		static void Main(string[] args)
		{
			Console.WriteLine("Hello DataTypes");
			//Console.WriteLine(sizeof(bool));
			//Console.WriteLine(true);
			//Console.WriteLine(false);
			//Console.WriteLine(bool.FalseString);

			//Console.WriteLine(sizeof(char)); //Unicode
			//Console.WriteLine('+'.GetType());

			/*
			 byte   sbyte   1 Byte;
			short   (Int16) == ushort (UInt16) 2 Bytes;
			int     (Int32) == uint   (UInt32) 4 Bytes;
			long    (Int64) == ulong  (UInt64) 8 Bytes;
			 */

			Console.WriteLine("Byte:");
			Console.WriteLine(sizeof(byte));
			Console.WriteLine(byte.MinValue);
			Console.WriteLine(byte.MaxValue);
			Console.WriteLine(delimiter);

			Console.WriteLine("SByte:");
			Console.WriteLine(sizeof(sbyte));
			Console.WriteLine(sbyte.MinValue);
			Console.WriteLine(sbyte.MaxValue);

			Console.WriteLine("Decimal");
			Console.WriteLine(sizeof(decimal));
			Console.WriteLine(decimal.MinValue);
			Console.WriteLine(decimal.MaxValue);
			Console.WriteLine(delimiter);

			//Console.WriteLine(5ul.GetType());

			//Console.WriteLine(2000000000.GetType());

			int a = 2000000000;
			int b = 4;
			//Console.WriteLine((a * b).GetType());
			//Console.WriteLine("Вот и сказочке конец");
			try
			{
				Console.WriteLine((a * b).GetType());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				
			}
			Console.WriteLine("Вот и сказочке конец");
		}
	}
}
