// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Write("Введите число b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "0");

int x = (b1-b2)/(k1-k2);

int y1 = (k1 * x + b1);
int y2 = (k2 * x + b2);

int y = y1 - y2;

Console.WriteLine($"Точка пересечения 2-х прямых x: {x}, y: {y}");

    



