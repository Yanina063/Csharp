
// В матрице чисел найти сумму элементов главной диагонали
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
//--------Сумма элементов главной диагонали-----
int SummaDiagonal(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
      sum = sum + matr[i,i];
    }
    return sum;
}

Console.Clear();

Console.Write("Введите кол-во строк 2хмерного массива: ");
int row = int.Parse(Console.ReadLine() ?? "0");

//Console.Write("Введите кол-во столбцов 2хмерного массива: ");
//int colums = int.Parse(Console.ReadLine() ?? "0");

int[,] matr = new int[row, row];

FillArray(matr);

Console.WriteLine("массив: ");

PrintArray(matr);

int result = SummaDiagonal(matr);
Console.Write($"Сумма элементов главной диагонали: {result}");
