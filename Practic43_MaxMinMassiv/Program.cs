//В указанном диапазоне вещественных чисел найдите разницу между максимальным и минимальным элементом
float [] arr = {3.5f, 4.5f, 5.8f, 9.1f};
float max = arr[1];
float min = arr[0];
for (int i = 0; i < arr.Length; i++)
{ 
    if(arr[i] > max)
    {
        max = arr[i];
    }
    if(arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine($"Разница между {max} и {min} = {max-min}");
