using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Написать программу, которая обменивает элементы первой строки и последней строки
            void FillArray(int[,] matr)
            {
                Random rnd = new Random();

                int rowLengh = matr.GetLength(0);
                int columsLengh = matr.GetLength(1);

                for (int i = 0; i < rowLengh; i++)
                {
                    for (int j = 0; j < columsLengh; j++)
                    {
                        matr[i, j] = rnd.Next(0, 10);
                    }
                }
            }

            //-----------------Печать массива
            void PrintArray(int[,] matr)
            {
                int rowLengh = matr.GetLength(0);
                int columsLengh = matr.GetLength(1);
                for (int i = 0; i < rowLengh; i++)
                {
                    for (int j = 0; j < columsLengh; j++)
                    {
                        Console.Write(matr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            int[,] MultiplMatrix(int[,] matr1, int[,] matr2)
            {
                int rowLengh = matr1.GetLength(0);
                int columsLengh = matr1.GetLength(1);

                int[,] resultMatrix = new int[rowLengh, columsLengh];

                for (int i = 0; i < rowLengh; i++)
                {
                    for (int j = 0; j < columsLengh; j++)
                    {
                        resultMatrix[i, j] = matr1[i, j] * matr2[i, j];
                    }
                }

                return resultMatrix;
            }


            Console.Clear();

            Console.Write("Введите кол-во строк 2хмерного массива: ");
            int row = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Введите кол-во столбцов 2хмерного массива: ");
            int colums = int.Parse(Console.ReadLine() ?? "0");

            int[,] matr1 = new int[row, colums];
            int[,] matr2 = new int[row, colums];

            FillArray(matr1);
            FillArray(matr2);

            Console.WriteLine("массив 1: ");

            PrintArray(matr1);

            Console.WriteLine("массив 2: ");

            PrintArray(matr2);

            Console.WriteLine("Результат умножения матриц: ");

            int[,] result = MultiplMatrix(matr1, matr2);

            PrintArray(result);
        }
    }
}
