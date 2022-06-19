using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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

            int[] FindMinimumElement(int[,] matr)
            {
                int rowLength = matr.GetLength(0);
                int columnsLength = matr.GetLength(1);

                int minElement = matr[0, 0];
                int[] index = { 0, 0 };
                
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < columnsLength; j++)
                    {
                        if (matr[i, j] < minElement)
                        {
                            minElement = matr[i, j];

                            index[0] = i;
                            index[1] = j;

                            Console.WriteLine();
                            Console.WriteLine($"minElement: {minElement} Row: {i} Col: {j}");
                            Console.WriteLine();
                        }
                    }
                }

                return index;
            }

            int[,] RemoveRowAndColumFromMatrix(int[,] matr, int[] indexs)
            {
                int rowLength = matr.GetLength(0);
                int columnsLength = matr.GetLength(1);

                int[,] result = new int[rowLength - 1, columnsLength - 1];

                for (int i = 0; i < rowLength - 1; i++)
                {

                    for (int j = 0; j < columnsLength - 1; j++)
                    {
                        int i1 = i >= indexs[0] ? i + 1 : i;
                        int j1 = j >= indexs[1] ? j + 1 : j;

                        result[i, j] = matr[i1, j1];
                    }
                }

                return result;
            }

            Console.Clear();

            Console.Write("Введите кол-во строк 2хмерного массива: ");
            int row = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Введите кол-во столбцов 2хмерного массива: ");
            int colums = int.Parse(Console.ReadLine() ?? "0");

            int[,] matr = new int[row, colums];
            
            FillArray(matr);
            
            PrintArray(matr);

            int[] minIndex = FindMinimumElement(matr);

            int[,] res = RemoveRowAndColumFromMatrix(matr, minIndex);

            Console.WriteLine("Результат удаления строки и столбца из матрицы: ");

            PrintArray(res);
        }
    }
}
