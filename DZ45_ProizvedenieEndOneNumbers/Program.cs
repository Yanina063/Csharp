//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] arr = new int[10];  //задаем сам массив

for (int i = 0; i < arr.Length; i++)
{
   arr[i] = new Random().Next(0,10);
}

Console.WriteLine();
Console.Write($"arr = ");
for (int i = 0; i < arr.Length; i++) 
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();


int endCounter = arr.Length - 1;

for (int startCounter = 0; startCounter < arr.Length / 2; startCounter++ ) 
{
    int res = arr[startCounter] * arr[endCounter];
    Console.WriteLine($"res = {res}");
    endCounter--;
}
Console.WriteLine();

