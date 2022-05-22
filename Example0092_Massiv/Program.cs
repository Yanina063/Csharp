// Методы и описание в массиве
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //назначаем коолекцию из нов.рандомных чисел от 1 до 10
        index++; // index = index + 1
    }
}

void PrintArrey(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)
{

    int count = collection.Length; //Количество элементов
    int index = 0;
    int position = -1; //Если у нас нет элемента или он не встречается в массиве
    while (index < count)
    {
        if(collection[index] == find);
        {
            position = index;
            break;
        }
        index = index + 1;
    }
    return position;
}


int[] array = new int[10]; //определили массив из 10 элементов

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArrey(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
