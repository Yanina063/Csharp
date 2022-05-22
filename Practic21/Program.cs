// Определить номер плоскости, в которой находится точка X и Y, причем х,y не равны нулю.
Console.WriteLine("Введите координаты x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y: ");
int y = int.Parse(Console.ReadLine());
if(x > 0 && y > 0)
Console.WriteLine("точка находится в Плоскости 1");
else if (x > 0 && y < 0)
Console.WriteLine("точка находится в Плоскости 2");
if(x < 0 && y < 0)
Console.WriteLine("точка находится в Плоскости 3");
else if (x < 0 && y > 0)
Console.WriteLine("точка находится в Плоскости 4");
