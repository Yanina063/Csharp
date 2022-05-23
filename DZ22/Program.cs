// Выяснить, является ли число квадратом ддругого
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine());
int c = a * a;

if(c == b)
{
   Console.WriteLine($"Число {b} является квадратом: {a}");  
}
else 
{
    Console.WriteLine($"Число {b} не не является квадратом: {a}");
}

