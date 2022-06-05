//Определить сумму чисел одномерного массива, стоящих на нечетной позиции
int[] arr = new int [8];
for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(1,10);
int sum = 0;
for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
Console.WriteLine();
for (int i = 0; i < arr.Length; i = i + 2)
{
    sum = sum + arr[i];
}
Console.WriteLine($"Сумма нечетных элементов массива равна {sum} ");
