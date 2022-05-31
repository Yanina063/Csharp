//Возвести число A в натуральную степень B используя цикл
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());

int init_A = A;

for (int i = 1; i < B; i++)
{
    A = A * init_A;
}
Console.WriteLine($"B = {B} A = {A}");