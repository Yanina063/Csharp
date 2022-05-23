// Задать номер четверти. Показать диапазон возможных координат.
Console.WriteLine("Введите номер четверти: ");
int Plase = int.Parse(Console.ReadLine());

if(Plase == 1) 
{
Console.WriteLine("точка находится в Плоскости 1");
Console.WriteLine("Имеет все значение от x > 0 и y > 0");
} else if(Plase == 2) 
{
Console.WriteLine("точка находится в Плоскости 2");
Console.WriteLine("Имеет все значение от x > 0 и y < 0");
} else if(Plase == 3) 
{
Console.WriteLine("точка находится в Плоскости 3");
Console.WriteLine("Имеет все значение от x < 0 и y < 0");
} else if(Plase == 4) 
{
Console.WriteLine("точка находится в Плоскости 4");
Console.WriteLine("Имеет все значение от x < 0 и y > 0");
} else {
Console.WriteLine("Ошибка ввода координат");
}
