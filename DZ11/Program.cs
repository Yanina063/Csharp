// По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

int c = b * b;
Console.WriteLine(c);

if (a == c)
 {
   Console.Write("a является квадратом числа b");
   Console.WriteLine(a); 
 }
else {
    Console.Write("Число a не является квадратом b");
}

