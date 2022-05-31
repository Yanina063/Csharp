//Произведение чисел от 1 до N
Console.WriteLine("Введите число: ");
int P = int.Parse(Console.ReadLine());
for (int i = 0; i <= P - 1; i++)
{
    Console.WriteLine($"{i} * {i + 1} = {i * (i + 1)}");
}
