// Удалить вторую цыфру 3хзначного числа
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int b = a / 100;
int c = a % 10;
int d = b * 10 + c;
if (a > 99 && a < 1000)
{
   Console.Write("Вторая цифра 3-х значного числа = ");
   Console.WriteLine(a / 10 % 10);  
}
else {
    Console.Write("Число не 3-х значное");
}
Console.WriteLine(d);
