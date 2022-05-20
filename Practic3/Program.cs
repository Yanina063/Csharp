// Сравнить три числа
//Сравнить два числа

int a = new Random().Next(1,10);
Console.WriteLine(a);

int b = new Random().Next(1,10);
Console.WriteLine(b);

int d = new Random().Next(1,10);
Console.WriteLine(d);

int max = a;
if(b > max) {
    max = b;
}
if(d > max) {
    max = d;
}
int min = a;
if(b < min) {
    min = b;
}
if(d < min) {
    min = d;
}

int mid = a;
if(max > b && b > min) {
    mid = b;
}
if(max > d && d > min) {
    mid = d;
}

Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");
Console.WriteLine($"Mid: {mid}");
Console.WriteLine($"{max} > {mid} > {min}");