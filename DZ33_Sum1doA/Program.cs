//Найти сумму чисел от 1 до A
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
for (int i = 0; i <= A - 1; i++)
{
    Console.WriteLine($"{i} + {i + 1} = {i + (i + 1)}");
}