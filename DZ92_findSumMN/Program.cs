//Найти сумму элементов от M до N, N и M заданы
void PrintNums(int M, int N)
{
    int sum = M;
    while(++M <= N) {
        sum = sum + M;
    }
    Console.WriteLine(sum);
}

Console.Write("Введите первый элемент : ");
int M = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите второй элемент : ");
int N = int.Parse(Console.ReadLine()?? "");
PrintNums(M,N);