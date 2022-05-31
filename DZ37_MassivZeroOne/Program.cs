// Задать массив из 8 элементов, заполненных нулями и еденицами. Вывести их на экран.

//Задать массив из 8 элементов и вывести их на экран
Console.WriteLine("Введите 8 элементов");
int[] array = new int[8];  //задаем сам массив
for(int i = 1; i <= 8; i++)
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

//2/Вывести на экран значения 0 и 1
Console.WriteLine();
PrintArray1(array);

bool IsZeroOrOne(int number) {
    int lastNumber = number % 10;
    return lastNumber == 0 || lastNumber == 1; 
}

//-----------Функция ввода чисел массива с 1 и 0 на экран-----------------
void PrintArray1(int[] array)
{
    for(int i = 0; i < array.Length; i = i + 1)
    {
        if(IsZeroOrOne(array[i]))
        Console.Write(array[i] + " ");
    }
}
//--------------------------------------------------------------------------