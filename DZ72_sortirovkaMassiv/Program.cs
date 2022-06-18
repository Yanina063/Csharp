//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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
//-------Сортировка одной строки -------
void CompareOnlyRow(int[,] matr, int indexRow) {

    int columsLengh = matr.GetLength(1) - 1;
    for (int j = 0; j < columsLengh; j++)  
      {
         if(matr[indexRow, j] < matr[indexRow, j + 1]) {
            int temp = matr[indexRow, j];
            matr[indexRow, j] = matr[indexRow, j + 1];
            matr[indexRow, j + 1] = temp;
         }
      }
}


void SortMassive(int[,] matr)
{
    int rowLengh = matr.GetLength(0);
    // Ходим по строкам
    for (int i = 0; i < rowLengh; i++)
    {
         int columsLengh = matr.GetLength(1) - 1;
        while(columsLengh > 0) {

         CompareOnlyRow(matr, i);
         columsLengh--;
        }
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

SortMassive(matr);

PrintArray(matr);
