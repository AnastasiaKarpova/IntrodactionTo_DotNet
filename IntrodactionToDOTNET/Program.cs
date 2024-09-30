//#define CONSOLE_CLASS
//#define STRING_OPERATIONS
//#define HARD_CHESS
//#define GEOMETRIA
#define CHESS_BOARD
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntrodactionToDOTNET
{
    internal class Program
    {
        static readonly string delimiter = "\n-----------------------------------------------------------\n";
        static void Main(string[] args)
        {
#if CONSOLE_CLASS
            Console.Title = "Introdaction to .NET";
            Console.WriteLine("\t\t\tHello .NET");
            //Console.CursorLeft = 25;
            //Console.CursorTop = 8;
            Console.SetCursorPosition(24, 5);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Привет .NET");
            Console.ResetColor();

            Console.WriteLine(delimiter);


            Console.WriteLine("Позиция окна консоли: " + Console.WindowLeft + " знакопозиций");
            Console.WriteLine("Позиция окна консоли: " + Console.WindowTop + " знакопозиций");

            Console.SetWindowSize(91, 22);
            Console.WriteLine("Ширина окна консоли: " + Console.WindowWidth + " знакопозиций");
            Console.WriteLine("Высота окна консоли: " + Console.WindowHeight + " знакопозиций");

            Console.SetBufferSize(91, 22);
            Console.WriteLine("Ширина буфера консоли: " + Console.BufferWidth + " знакопозиций");
            Console.WriteLine("Высота буфера консоли: " + Console.BufferHeight + " знакопозиций"); 
#endif
#if STRING_OPERATIONS
            Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine();

            Console.Write("Введите Вашу фамилию: ");
            string last_name = Console.ReadLine();

            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(first_name + " " + last_name + " " + age); //конкатенация строк
            Console.WriteLine(String.Format("{0}, {1}, {2}", first_name, last_name, age)); //форматирование строк
            Console.WriteLine($"{first_name}, {last_name}, {age}"); //Интерполяция строк  
#endif

#if HARD_CHESS
            Console.Write("Введите размер шахматной доски: ");
            int size_board = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите размер клетки шахматной доски: ");
			int size = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < size_board; i++)
            {
                if(i % 2 == 0)
                {
                    for(int j = 0; j < size; j++)
                    {
                        for(int z = 0; z < size_board; z++)
                        {
                            if(z % 2 == 0)
                            {
                                for (int x = 0; x < size; x++)
                                {
                                    Console.Write("* ");
                                }
                            }
                            else
                            {
                                for (int x = 0; x < size; ++x)
                                {
									Console.Write("  ");
								}
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for(int j = 0; j < size; ++j)
                    {
                        for (int z = 0; z < size_board; ++z)
                        {
                            if (z % 2 == 0)
                            {
                                for (int x = 0; x < size; ++x)
                                {
									Console.Write("  ");
								}
                            }
                            else
                            {
								for (int x = 0; x < size; ++x)
								{
									Console.Write("* ");
								}
							}
                        }
						Console.WriteLine();
					}
                }
            }
#endif
#if GEOMETRIA
			Console.Write("Укажите размер фигуры: ");
			int size = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine();
			for (int y = 0; y < size; y++)
			{
				for (int x = 0; x < size; x++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

            Console.WriteLine();

			for (int y = 0; y < size; y++)
            {
                for(int x = 0; x < size; x++)
                {
                    if(y>=x)
                    {
						Console.Write("*");
					}
                    else
                    {
						Console.Write(" ");
					}
                }
                Console.WriteLine();
            }
			Console.WriteLine();

            for(int y = 0; y < size; y++)
            {
                for(int x = 0; x <size - y; x++)
                {
					Console.Write("*");
				}
				Console.WriteLine();
			}

			Console.WriteLine();

			for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if(x>=y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

			Console.WriteLine();

            for(int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
					if (y+x >= size - 1)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine();

            for (int y = 0; y < size; y++)
            {
                for (int x = y; x < size; x++)
                {
					Console.Write(" ");
				}
				Console.Write("/");
                for (int x = 0; x < y * 2; x++)
                {
					Console.Write(" ");
				}
				Console.Write("\\");
				Console.WriteLine();
			}
            for (int y = 0; y < size; y++)
            {
                for(int x = 0; x <= y; x++)
                {
					Console.Write(" ");
				}
				Console.Write("\\");
                for (int x = (y + 1) * 2; x < size * 2; x++)
                {
					Console.Write(" ");
				}
				Console.Write("/");
				Console.WriteLine();
			}

			Console.WriteLine();

			for (int y = 0; y < size; y++)
			{
				for (int x = 0; x < size; x++)
				{
					if ((x+y) % 2 == 0)
					{
						Console.Write("+ ");
					}
					else
					{
						Console.Write("- ");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif
#if CHESS_BOARD
            Console.Write("Введите размер шахматной доски: ");
            int size_board = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите размер клетки шахматной доски: ");
			int size = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < size_board; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        for (int j = 0; j < size; j++)
            //        {
            //            for (int z = 0; z < size_board; z++)
            //            {
            //                if (z % 2 == 0)
            //                {
            //                    for (int x = 0; x < size; x++)
            //                    {

            //                    }
            //                }
            //                else
            //                {
            //                    for (int x = 0; x < size; ++x)
            //                    {

            //                    }
            //                }
            //            }
            //            Console.WriteLine();
            //        }
            //    }
            //    else
            //    {
            //        for (int j = 0; j < size; ++j)
            //        {
            //            for (int z = 0; z < size_board; ++z)
            //            {
            //                if (z % 2 == 0)
            //                {
            //                    for (int x = 0; x < size; ++x)
            //                    {

            //                    }
            //                }
            //                else
            //                {
            //                    for (int x = 0; x < size; ++x)
            //                    {

            //                    }
            //                }
            //            }
            //            Console.WriteLine();
            //        }
            //    }
            //}
#endif

        }
	}
}
