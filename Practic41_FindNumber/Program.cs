//Определить, присутствует ли число в массиве
int[] arr = {-3, 1, 59, 40, 12, 9, 0, 5};
for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
Console.WriteLine();
Console.WriteLine("Введите число для поиска в массиве: ");
int num = int.Parse (Console.ReadLine()  ?? "0");
int check = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == num)
    {
        Console.WriteLine($"Заданное число {num} найдено в массиве!");
        check = 1;
        break;
    }
}
if (check == 0) Console.WriteLine($"Заданное число {num} не найдено в массиве.");