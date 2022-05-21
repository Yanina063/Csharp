// Позаданному номеру дня недели вывести его название
Console.Write("Ввести номер дня недели от 1 до 7 ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine(a);
if (a == 1)
 {
   Console.Write("a соответствует дню недели");
   Console.WriteLine(" понедельник"); 
 }
if (a == 2)
 {
   Console.Write("a соответствует дню недели");
   Console.WriteLine(" вторник"); 
 }
 if (a == 3)
 {
   Console.Write("a соответствует дню недели");
   Console.WriteLine(" среда"); 
 }
 if (a == 4)
 {
   Console.Write("a соответствует дню недели");
   Console.WriteLine(" четверг"); 
 }
 if (a == 5)
 {
   Console.Write("a соответствует дню недели");
   Console.WriteLine(" пятница"); 
 }
 if (a == 6)
 {
   Console.Write("a соответствует дню недели");
   Console.WriteLine(" суббота"); 
 }
 if (a == 7)
 {
   Console.Write("a соответствует дню недели");
   Console.WriteLine(" воскресенье"); 
 }

string [] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string day = days[a - 1];
Console.WriteLine($"Наш день недели из массива: {day}");