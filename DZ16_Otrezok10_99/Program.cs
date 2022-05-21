// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.
int a = int.Parse(Console.ReadLine());
int b = a / 10 % 10;
int c = a % 10; 
if (a > 10 && a < 99)
if(b > c)
{
    Console.Write("Наибольшая цифра числа: ");
    Console.WriteLine(b);
}
else
{
    Console.Write("Наибольшая цифра числа: ");
    Console.WriteLine(c);
} 





