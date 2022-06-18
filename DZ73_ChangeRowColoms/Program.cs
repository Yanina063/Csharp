//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
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

int[,] InvertMassive(int[,] matr)
{
    int rowLengh = matr.GetLength(0);
    int columsLengh = matr.GetLength(1);
    // 
    int[,]  invertMatr = new int[rowLengh, columsLengh];

    for (int i = 0; i < rowLengh; i++)
    {
        for (int j = 0; j < columsLengh; j++)  
      {
        matr[j, i] = matr[i, j];
      }
    }
    return invertMatr;
}




Console.Clear();

Console.Write("Введите кол-во строк 2хмерного массива: ");
int row = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите кол-во столбцов 2хмерного массива: ");
int colums = int.Parse(Console.ReadLine() ?? "0");

if(row == colums) {

int[,] matr = new int[row, colums];

FillArray(matr);

Console.WriteLine("массив: ");

PrintArray(matr);

Console.WriteLine("Результат замены элементов первой строки и последней строки: ");

int[,] invertMatr = InvertMassive(matr);

PrintArray(invertMatr);
} else {
  Console.WriteLine("Не Квадратный массив !!! ");  
}




