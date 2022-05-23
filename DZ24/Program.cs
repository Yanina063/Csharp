// Найти расстояние между точками в пространстве 2D/3D
// Задать номер четверти. Показать диапазон возможных координат.
Console.WriteLine("Введите координату точки 1 x: ");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки 1 y: ");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки 1 z: ");
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату точки 2 x: ");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки 2 y: ");
int Y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки 2 z: ");
int Z2 = int.Parse(Console.ReadLine());

//Вычисление расстояния между точками в 2D
double x = (double)(X2 - X1);
double y =  (double)(Y2 - Y1);
double xy = Math.Sqrt(x * x + y * y);
Console.WriteLine("Расстояние между точками XY в 2D: ");
Console.WriteLine(xy);

//Вычисление расстояния между точками в 3D
double z =  (double)(Z2 - Z1);
double xyz = Math.Sqrt(x * x + y * y + z * z);
Console.WriteLine("Расстояние между точками XY в 3D: ");
Console.WriteLine(xyz);

