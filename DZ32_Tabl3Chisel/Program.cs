//Показать таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} * {i} * {i} = {i * i * i}");
}
