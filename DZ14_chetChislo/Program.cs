// Показать четные числа от 1 до N
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Все четные числа до N: ");
for(int i = 1; i <= N; i++) 
{
  if(i % 2 == 0) {
      Console.Write($"{i}, ");
     
  }
}