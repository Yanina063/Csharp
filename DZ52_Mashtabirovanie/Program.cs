// Написать программу масштабирования фигуры (прямоугольник)

int x1 = 5;
int x2 = 10;
int x3 = 15;
int x4 = 7;

int y1 = 5;
int y2 = 10;
int y3 = 15;
int y4 = 20;

Console.Write("Введите коэффициент: ");
int k = int.Parse(Console.ReadLine() ?? "0");
x1 = x1*k;
x2 = x2*k;
x3 = x3*k;
x4 = x4*k;

y1 = y1*k;
y2 = y2*k;
y3 = y3*k;
y4 = y4*k;

Console.WriteLine($"Новые координаты фигуры: x1: {x1}, y1: {y1}, x2: {x2}, y2: {y2}, x3: {x3}, y3: {y3}, x4: {x4}, y4: {y4}");
