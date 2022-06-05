// See https://aka.ms/new-console-template for more information
/*string[,] table = new string[2, 5];
// table[0, 0] table[0, 1] table[0, 2] ... table[0, 4] индекс меняется от 0
// table[1, 0] table[1, 1] table[1, 2] ... table[1, 4] индекс меняется от 0
table[1, 2] = "слово";
for (int rows = 0; rows < 2; rows++) //кол-во строк
{
    for (int columns = 0; columns < 5; columns++) //кол-во столбцов
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}

int[,] matrix = new int[3, 4];
for (int i = 0; i < 3; i++) //кол-во строк
{
    for (int j = 0; j < 4; j++) //кол-во столбцов
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}*/

//или можно записать так:
//int[,] matrix = new int[3, 4];
//for (int i = 0; i < matrix.GetLength(0); i++) //кол-во строк
//{
//    for (int j = 0; j < matrix.GetLength(1); j++) //кол-во столбцов
//    {
//        Console.Write($"{matrix[i, j]} ");
//    }
//    Console.WriteLine();
//}
/*
//записываем в виде метода, который в последующем можно вызывать:
void PrintArrey(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //кол-во строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //кол-во столбцов
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArrey(int[,] matr) //записываем метод, который будет заполнять таблицу случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++) //кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) //кол-во столбцов
        {
            matr[i,j] = new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];
PrintArrey(matrix);
FillArrey(matrix);
Console.WriteLine();
PrintArrey(matrix);
*/
// Рисуем руку
int[,] pic = new int[,]; // в лекции массив задан явно: весь перечислен

void PrintImage(int[,] image) //записываем метод, который будет заполнять таблицу случайными числами
{
    for (int i = 0; i < image.GetLength(0); i++) //кол-во строк
    {
        for (int j = 0; j < image.GetLength(1); j++) //кол-во столбцов
        {
           //Console.WriteLine($"{image[i, j]});
           if(image[i, j] == 0) Console.Write($" "); //если i и j равны нулю - печатаем пробел.
           else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImadg(int row, int col) //Функция для закрашивания картинки, задаем позицию строки и пиксела, с которого все начинается 
{
    if(pic[row, col] == 0); //если наш пиксель не закрашен
    {
        pic[row, col] = 1;
        //------рекурсия- функция, которая вызывает сама себя ------
        FillImage(row-1, col); //порядок проверки пикселей и их закрашивание, согласно нашей договоренности 
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
        //-----------------------
    }
}

PrintImage(pic);
FillImage(13, 13); //точка, с которой начинается закрашивание
PrintImage(pic);


//----------- простой пример рекурсии Факториал !5=5*4*3*2*1 ------------------

double Factorial (double n)
{
   // 1! = 1
   // 0! = 1
   if(n ==1) return 1;
   else return n * Factorial(nint-1);
}
for (double i = 0; i < 40; i++) //во избежание переполнения меняем int на
{
  Console.WriteLine($"{i}! = {Factorial(i)}");
}

Console.WriteLine(Factorial(3)); //1*2*3 = 6

//--------Рекурсия Фибоначчи 1 1 2 3 5 8 13...-------------------
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 10; i++) //во избежание переполнения меняем int на
{
  Console.WriteLine(Fibonacci(i));
}