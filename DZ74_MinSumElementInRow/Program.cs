//В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillArray(int[,] matr)
{
    Random rnd = new Random();

    int rowLengh = matr.GetLength(0);
    int columsLengh = matr.GetLength(1);

    for (int i = 0; i < rowLengh; i++)
    {
      for (int j = 0; j < columsLengh; j++)  
      {
        matr [i,j] = rnd.Next(0,10);
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
        Console.Write(matr[i,j] + " ");
      }
      Console.WriteLine();
    }
}

int SumMinRow(int[,] matr)
{
    int rowLengh = matr.GetLength(0);
    int columsLengh = matr.GetLength(1);
    // 
    int sumMinRow = 0;
    for (int i = 0; i < rowLengh; i++)
    {
        int sumRow = 0;
        //строки
        for (int j = 0; j < columsLengh; j++)  
        {
           int el = matr[i, j];
           sumRow = sumRow + el;
        }
        ///


        if(i == 0) {
            sumMinRow = sumRow;
        }


        if(sumMinRow > sumRow) {
            sumMinRow = sumRow;
        }
    }
    return sumMinRow;
}




Console.Clear();

Console.Write("Введите кол-во строк 2хмерного массива: ");
int row = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите кол-во столбцов 2хмерного массива: ");
int colums = int.Parse(Console.ReadLine() ?? "0");

int[,] matr = new int[row, colums];

FillArray(matr);

Console.WriteLine("массив: ");

PrintArray(matr);

Console.WriteLine($"SumMinRow: {SumMinRow(matr)}");






