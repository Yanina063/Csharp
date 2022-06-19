//Показать натуральные числа от M до N, N и M заданы
void PrintNums(int M, int N, int I)
{
    if(I==N) return ;
    Console.WriteLine(M);
    int tmp = M;
    M += 1;
    PrintNums(M,N,I-1);
}

Console.Write("Введите число I: ");
int I = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите первый элемент : ");
int M = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите второй элемент : ");
int N = int.Parse(Console.ReadLine()?? "");

PrintNums(M,N,I);




