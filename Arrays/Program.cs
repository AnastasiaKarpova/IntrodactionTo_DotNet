//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAYS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if ARRAYS_1
			//int max = 0;
			//int min = 0;
			int summ = 0;
			
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr = {3, 5, 8, 13, 21};
			int[] arr = new int[n];
			Random rand = new Random(0); //0 - Seed value
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
				//Next(int upperLimit); //Возвращает случайное число до 'upperLimit'
				//Next(iny lowerLimit, int upperLimit); //Возвращает случайное число 
			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine(); 

			foreach(int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();

			//min = arr[0];
			//max = arr[0];
			//for(int i = 1; i < n; i++)
			//{
			//	if(arr[i] < min)
			//	{
			//		min = arr[i];
			//	}
			//	if(arr[i] > max)
			//	{
			//		max = arr[i];
			//	}
			//}
			Console.WriteLine();
			//Console.WriteLine("Min: " + min);
			//Console.WriteLine("Max: " + max);
			Console.WriteLine("Min: " + arr.Min());
			Console.WriteLine("Max: " + arr.Max());
			int sum = arr.Sum();
			Console.WriteLine("Сумма: " + sum);
			int average;
			for(int i = 0; i<arr.Length;i++) {summ += arr[i];}
			average = summ / arr.Length;
			Console.WriteLine("Среднее арифметическое: " + average);
			//Console.WriteLine("Сумма: " + summ);
			Array.Sort(arr);
			Console.Write("Отсортированный массив: ");
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
#endif
#if ARRAYS_2
			int max = 0;
			int min = 0;
			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];

			Console.WriteLine(i_arr_2.Rank);

			Random rand = new Random(0);
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}

			foreach (int i in i_arr_2)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			min = i_arr_2[0,0];
			max = i_arr_2[0,0];
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(0); j++)
				{
					if (i_arr_2[i, j] < min)
					{
						min = i_arr_2[i, j];
					}
					if (i_arr_2[i, j] > max)
					{
						max = i_arr_2[i, j];
					} 
				}
			}
			Console.WriteLine();
			Console.WriteLine("Min: " + min);
			Console.WriteLine("Max: " + max);
			int sum = 0;
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(0); j++)
				{
					sum += i_arr_2[i,j]; 
				}
			}
			Console.WriteLine("Сумма: " + sum);
			Console.WriteLine("Среднее арифметическое: " + sum / i_arr_2.Length);
			Console.WriteLine();
#endif
#if JAGGED_ARRAYS
			
			int[][] arr_jagged = new int[][]
			{
				new int[]{0, 1, 1, 2 },
				new int[]{3, 5, 8, 13, 21 },
				new int[]{34, 55, 89 },
				new int[]{144, 233, 377, 610, 987 }
			};
			int max = arr_jagged[0][0];
			int min = arr_jagged[0][0];
			for (int i = 0; i <arr_jagged.Length;i++)
			{
				for(int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			
			for (int i = 0; i < arr_jagged.Length; i++)
			{
					if (arr_jagged[i].Min() < min)
					{
						min = arr_jagged[i].Min();
					}
					if (arr_jagged[i].Max() > max)
					{
						max = arr_jagged[i].Max();
					} 
			}
			Console.WriteLine();
			Console.WriteLine("Min: " + min);
			Console.WriteLine("Max: " + max);
			int sum = 0;
			for (int i = 0; i < arr_jagged.Length; i++)
			{
				sum += arr_jagged[i].Sum();
			}
			Console.WriteLine("Сумма: " + sum);
			Console.WriteLine("Среднее арифметическое: " + sum / arr_jagged.Length);
#endif

		}
	}
}
