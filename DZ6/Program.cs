// Показать двумерный массив размером m×n заполненный вещественными числами
Console.Write("Введите кол-во строк 2хмерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов 2хмерного массива: ");
int k = int.Parse(Console.ReadLine() ?? "0");
double[,] matrix = new double[n,k];
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < k; j++)
    {
        matrix[i,j] =  new Random().NextDouble();
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
