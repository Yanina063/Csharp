// ьассив arrey из n элементов, найти элемент массива равный find
int[] arrey = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = arrey.Length;
int find = 18;

int index = 0;
while (index < n)
{
    if(arrey[index] == find)
    {Console.WriteLine(index);
    break; //если есть повторяющиеся элементы в массиве, чтобы все не показывать и остановиться на певром условии
    }
    index++; //index = index +1;
}