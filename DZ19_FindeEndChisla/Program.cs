// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int b = a % 10;
if (a > 99 && a < 1000)
{
   Console.Write($"Последняя 3-х значного числа = {b}");  
}
else {
    Console.Write("Число не 3-х значное");
}

