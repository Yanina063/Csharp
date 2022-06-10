//Найти сумму цифр числа
/*int n = 100;
int Sum(int n)
{
 if(n < 1) return 0;
 else return Sum (n / 10) + n % 10;
}
Console.WriteLine(Sum(n));

/*или
uint SumDigits(uint n) => n<10 ? n : n%10 + SumDigits(n/10);
Console.Write("Enter your number: ");
uint n = uint.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Sum of digits {SumDigits(n)}");
/*

//Написать программу возведения числа А в целую стень B
int Amout(int a, int b) => b==1 ? a : a*Amout(a,b-1);
Console/Write($"Введите число, которое надо возвести в степень: ");
int a = int.Parse(Console.ReadLine()?? "0");
Console.Wride("Введите степень: ");
int b = int.Parse(Console.ReadLine()?? "0");
Console.Wrideline(Amout(a,b));

//Написать программу показывающие первые N(Количество чисел) чисел, для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем
*/
void PrintNums(int first, int second, int n)
{
    if(n==0) return ;
    Console.WriteLine(first + second);
    int tmp = first;
    first = second;
    second += tmp;
    PrintNums(first,second,n-1);
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите первый элемент : ");
int first = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите второй элемент : ");
int second = int.Parse(Console.ReadLine()?? "");

PrintNums(first,second,N);



