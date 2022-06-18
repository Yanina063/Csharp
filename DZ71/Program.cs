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

void ChangePositionElement(int[,] matr)
{
    int rowLengh = matr.GetLength(0) - 1;
    int columsLengh = matr.GetLength(1);

      for (int j = 0; j < columsLengh; j++)  
      {
        int temp = matr[0, j];
        matr[0, j] = matr[rowLengh, j];
        matr[rowLengh, j] = temp;
      }
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

 Console.WriteLine("Результат замены элементов первой строки и последней строки: ");

ChangePositionElement(matr);

PrintArray(matr);