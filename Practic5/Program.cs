// Ввести трехзначное число и вывести последюю цифру
Console.Write("Введите трехзначное число: ");
 int a = int.Parse(Console.ReadLine());
Console.Write("Последняя цифра 3-х значного числа = ");
Console.WriteLine(a % 10);