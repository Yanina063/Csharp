//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] arr = new int [12];
for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(-10,10);
for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
int sum = 0;
Console.WriteLine();
for (int i = 0; i < arr.Length; i++) 
{
    sum = sum + arr[i];
}
Console.WriteLine($"Сумма элементов массива равна {sum} ");