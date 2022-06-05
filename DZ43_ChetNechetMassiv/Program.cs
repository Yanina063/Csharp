//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] arr = new int[10];  //задаем сам массив
int counterShet = 0;
int counterNeShet = 0;

for (int i = 0; i < arr.Length; i++)
{
   arr[i] = new Random().Next(100,1000);

    if((arr[i] % 2) == 0) {

        counterShet++;
        Console.WriteLine($"Chet: {arr[i]}");

    } else {
        counterNeShet++;
        Console.WriteLine($"Ne Chet: {arr[i]}");
    }
}

Console.WriteLine($"counterShet: {counterShet}");
Console.WriteLine($"counterNeShet: {counterNeShet}");


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

PrintArray(arr);

