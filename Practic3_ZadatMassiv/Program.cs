// Задать массив из 8 элементов и вывести их на экран
Console.WriteLine("Введите 8 элементов");
int[] array = new int[8];  //задаем сам массив
for(int i = 1; i <=8; i++)
{
    Console.WriteLine($"Введите элемент номер {i}: \n");
    array[i-1] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
PrintArray(array);
//----------------------Функция ввода массива на экран--------------------
void PrintArray(int[] array)
{
    for(int i = 1; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
//------------------------------------------------------------------------