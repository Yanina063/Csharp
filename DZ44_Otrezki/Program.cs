//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] arr = new int[123];  //задаем сам массив
int counterOtrezok = 0;
int counterNeOtrezok = 0;

for (int i = 0; i < arr.Length; i++)
{
   arr[i] = new Random().Next(0,100);

    if(arr[i] > 10 & arr[i] < 99) {

        counterOtrezok++;
        Console.WriteLine($"Элемент отрезка: {arr[i]}");

    } else {
        counterNeOtrezok++;
        Console.WriteLine($"Элемент за пределами отрезка: {arr[i]}");
    }
}

Console.WriteLine($"Элемент отрезка: {counterOtrezok}");
Console.WriteLine($"Элемент за пределами отрезка: {counterNeOtrezok}");


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

PrintArray(arr);
