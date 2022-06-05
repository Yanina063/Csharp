// Задать массив из 8 элементов, заполненных нулями и еденицами. Вывести их на экран
int[,] massiv = new int[1, 8];
for (int i = 0; i < 1; i++) //кол-во строк
{
    for (int j = 0; j < 8; j++) //кол-во столбцов
    {
        Console.Write($"{massiv[i, j]} ");
    }
    Console.WriteLine();
}


// вариант 2
int[] arrey = {0, 1, 0, 0, 1, 1, 0, 1};
for (int i = 0; i < arrey.LongLength; i++) Console.Write($"{arrey[i]} ");
