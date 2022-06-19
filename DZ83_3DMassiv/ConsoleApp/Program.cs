using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
            void FillArray(int[,,] matr)
            {
                Random rnd = new Random();

                int rowLengh = matr.GetLength(0);
                int columsLengh = matr.GetLength(1);

                int number = 10;

                for (int i = 0; i < rowLengh; i++)
                {
                    for (int j = 0; j < columsLengh; j++)
                    {
                        for (int n = 0; n < matr.GetLength(2); n++)
                        {
                            if (number == 100)
                            {
                                number = 10;
                            }

                            matr[i, j, n] = number++;
                        }
                    }
                }
            }

            //-----------------Печать массива
            void PrintArray(int[,,] matr)
            {
                int rowLengh = matr.GetLength(0);
                int columsLengh = matr.GetLength(1);


                for (int i = 0; i < rowLengh; i++)
                {
                    for (int j = 0; j < columsLengh; j++)
                    {
                        for (int n = 0; n < matr.GetLength(2); n++)
                        {

                            Console.Write($"{matr[i, j, n]} ({i} {j} {n}),  ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }


            Console.Clear();

            Console.Write("Введите длину 3хмерного массива: ");
            int row = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Введите ширину 3хмерного массива: ");
            int colums = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Введите высоту 3хмерного массива: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            int[,,] matr = new int[row, colums, n];

       
            FillArray(matr);
            Console.WriteLine();
            Console.WriteLine("массив: ");
            Console.WriteLine();
            PrintArray(matr);
        }
    }
}
