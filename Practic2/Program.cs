//Сравнить два числа
int a = new Random().Next(1,10);
Console.WriteLine(a);

int b = new Random().Next(1,10);
Console.WriteLine(b);
if(a > b) 
{
    int max = a;
    int min = b;
}
Console.WriteLine("Максимум a = ");
if (b > a) 
{
    int max = b;
    int min = a;
}
Console.WriteLine("Максимум max = , min = ");
Console.WriteLine("Максимум max > min");

