// Определить кол-во цифр в числе
Console.WriteLine("Ввести число number: ");
int number = int.Parse(Console.ReadLine());
int count = 0;
int tmpnumber = number;
while(tmpnumber > 0)
{
    tmpnumber = tmpnumber / 10;
    count++;
}
Console.WriteLine($"Кол-во цифр {count} в числе {number}");
