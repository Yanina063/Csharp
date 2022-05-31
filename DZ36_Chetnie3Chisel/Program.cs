// Показать кубы чисел, заканчивающихся на четную цифру

//1. Показать таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} * {i} * {i} = {i * i * i}");
}

Console.WriteLine("Введите n элементов");
int[] array =new int[n];  //задаем сам массив
for(int i = 1; i <=n; i++)
{
    Console.WriteLine($"Введите элемент номер {i}: ");
    array[i-1] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
PrintArray(array);
//-----------Функция ввода четных чисел массива на экран-----------------
void PrintArray(int[] array)
{
    for(int i = 1; i < array.Length; i = i + 2)
    {
        Console.Write(array[i] + " ");
    }
}
//------------------------------------------------------------------------