//В двухмерном массиве заменить элементы, у которых оба индекса четные на их квадраты
Console.Write("Введите кол-во строк 2хмерного массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов 2хмерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] arr = new int[m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        arr[i,j] =  new Random().Next(0,20);
        Console.Write($"{arr[i,j]} ");
    }
}
Console.WriteLine();
Console.WriteLine("----------------");
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        if(i % 2 == 0 && j % 2 == 0)
        {
           arr[i,j] = arr[i,j] * arr[i,j]; 
           Console.Write($"{arr[i,j]} ");
        }
 
    }
}

   