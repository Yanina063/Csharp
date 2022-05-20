// Ввести трехзначное число и вывести последюю цифру
Console.Write("Введите трехзначное число: ");
 int a = int.Parse(Console.ReadLine());
 if (a > 99 && a < 1000)
 {
   Console.Write("Последняя цифра 3-х значного числа = ");
   Console.WriteLine(a % 10);  
 }
else {
    Console.Write("Число не 3-х значное");
}