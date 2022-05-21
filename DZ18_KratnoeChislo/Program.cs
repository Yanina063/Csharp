// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите число: ");
double a = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
double b = int.Parse(Console.ReadLine());
double c = b % a;

if(c == 0)
{
   Console.WriteLine($"Число {b} кратное: {a}");  
}
else 
{
    Console.WriteLine($"Число {b} не кратное: {a}");
}
Console.WriteLine($"Остаток: {c}");


