void  FillArray(int[] array)
{
    int tmp = 0;
    int index = 0;
    int length = array.Length;
    while(index < length)
    {
        tmp = number % 2;
        number = number /2;
        array[index] = tmp;

        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}
//Написать программу преобразования десятичного числа в двоичное
Console.WriteLine("Number?");
int number = int.Parse(Console.ReadLine());
int tmpnumber = number;
int tmp = 0;
int count = 0;
while(tmpnumber > 0) //считаем какое кол-во цифр нам потребуется для деления числа
    {
        tmp = tmpnumber % 2;
        tmpnumber = tmpnumber /2;
        count++;
    }

int[] array = new int[count];
FillArray(array);
PrintArray(array.Reverse().ToArray());


//Написать программу преобразования десятичного числа в двоичное.
//Решение в строку

//Console.WriteLine("Введите число");
//int a = int.Parse(Console.ReadLine());
//int b = 0;
//string result = " ";
//int result = 0;

//while(a > 0)
//{
    b = a % 2;
    result = b + result;
    a = a / 2;
  
//
//Console.WriteLine(result);
