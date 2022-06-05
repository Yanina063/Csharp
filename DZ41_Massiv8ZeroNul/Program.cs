// Задать массив из 8 элементов, заполненных нулями и еденицами. Вывести их на экран
int[] arr = new int [8];
for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0,2);
for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
Console.WriteLine();

// вариант 2
/*
int[] arrey = {0, 1, 0, 0, 1, 1, 0, 1};
for (int i = 0; i < arrey.LongLength; i++) Console.Write($"{arrey[i]} ");
*/