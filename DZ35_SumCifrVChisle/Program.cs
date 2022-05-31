//Посчитать сумму цифр в числе
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());

int sum = A % 10;

Console.Write($"sum = {sum}");

for (int i = A / 10; i > 0; i = i / 10)
{
    int ost = i % 10;
    sum = sum + ost;
    Console.Write($" + {ost}");
}
Console.Write($" = {sum}");
