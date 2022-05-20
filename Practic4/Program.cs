// Найти все нечетные числа о -n до n
Console.WriteLine("Введите число: ");
int n = new Random().Next(-10,10); //-9 -8 -7 ...0...7 8 9
Console.WriteLine(n);
int min = -n;

while(min <= n)
{
    Console.Write(" " + min);
    min ++;
}
