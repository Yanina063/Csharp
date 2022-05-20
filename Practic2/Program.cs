//Сравнить два числа

int a = new Random().Next(1,10);
Console.WriteLine(a);

int b = new Random().Next(1,10);
Console.WriteLine(b);
if(a > b) 
{
  Console.Write("Максимальное число ");
  Console.Write(a);
  Console.Write(" Минимальное число ");
  Console.Write(b);
}
else
{
  Console.Write(" Максимальное число ");
  Console.Write(b);
  Console.Write(" Минимальное число ");
  Console.Write(a);
}


