// Написать программу масштабирования фигуры (прямоугольник)

int [][] square = new int[4][];
square[0] = new int[2];
square[1] = new int[2];
square[2] = new int[2];
square[3] = new int[2]; 

void PrintArray(int [][] array) {

    Console.WriteLine("Результат Массив: ");

    for(int i = 0; i < array.Length; i++) {
      
        for(int j = 0; j < array[i].Length; j++) {

               Console.Write(" " + array[i][j]);
                 
        }
    }
}

int [][] InputArray(int [][] array) {
    
    for(int i = 0; i < array.Length; i++) {
      
        for(int j = 0; j < array[i].Length; j++) {

                Console.WriteLine("Введите число: ");
                int res = int.Parse(Console.ReadLine() ?? "0");
                 array[i][j] = res;
        }
    }

    return array;
}

int [][] MashtabArray(int [][] array, int k) {
    
    for(int i = 0; i < array.Length; i++) {
      
        for(int j = 0; j < array[i].Length; j++) {

                 array[i][j] = array[i][j] * k;
        }
    }

    return array;
}

int [][] filledArray = InputArray(square);

Console.WriteLine("введите коэффициент: ");
int k = int.Parse(Console.ReadLine() ?? "0");

int [][] MashtabArrayResult = MashtabArray(filledArray, k);

PrintArray(MashtabArrayResult);
