// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Ввести номер дня недели от 1 до 7 ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine(a);
if (a == 6 || a == 7)
 {
   Console.Write("Это выходной день");
 }
 else
 {
   Console.Write("Не является выходным днем");
 }
 