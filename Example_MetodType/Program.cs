// Типы методов

void Metod1()
{
    System.Console.WriteLine();
}
Metod1();

void Metod2(string msg)
{
    Console.WriteLine(msg);
}
Metod2(msg); //Metod2("Текст сообщения");

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; 
    }
}
Metod21("Текст", 4); //4 - Означает, что я хочу 4 раза увидеть это сообщение
//Если хотим указать явно, тогда пишем так:
//Metod21(msg: "Текст", count: 4);

//Вид3 Обязательно должны указать тип данных, которые ожидаем
int Metod3()
{
    return DataTime.Now,Year;  //Пишем то, что метод должен возвращать
}

int year = Method3();
Console.WriteLine(year);

//Вид4. Что-то принимают и возвращают
string Metod4(int count, string text)
{
    int i = 0;
    string result = string.Empty; //string.Empty == ""

     while (i < count)
     {
         result = result + text;
         i++;
     }
}
string res = Metod4(10, "asdf");
Console.WriteLine(res);