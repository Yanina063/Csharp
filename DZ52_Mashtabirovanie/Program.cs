// Написать программу масштабирования фигуры (прямоугольник)

internal class Program
{
    private static void Main(string[] args)
    {
        int[][] square = new int[4][];
        square[0] = new int[2];
        square[1] = new int[2];
        square[2] = new int[2];
        square[3] = new int[2];

        void PrintArray(int[][] array, int k)
        {

            Console.Write($"Результат Маштабирования: при k = {k} получаем ");

            for (int i = 0; i < array.Length; i++)
            {

                Console.Write($"({array[i][0]},{array[i][1]})");

            }
        }

        int[][] InputArray(int[][] array)
        {
            Console.WriteLine("Введите данные: ");
            string str = Console.ReadLine(); //  "(0,0) (2,0) (2,2) (0,2)"
            int r = 0;
            int j = 0;
            foreach (var literal in str)
            {
                if (int.TryParse(literal + "", out int i) == true)
                {
                  
                    array[r][j] = i;
                    j++;

                    if(j > 1) {
                        r++;
                        j = 0;
                    }
                }
            }

            return array;
        }

        int[][] MashtabArray(int[][] array, int k)
        {

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array[i].Length; j++)
                {

                    array[i][j] = array[i][j] * k;
                }
            }

            return array;
        }

        int[][] filledArray = InputArray(square);

        Console.WriteLine("введите коэффициент: ");
        int k = int.Parse(Console.ReadLine() ?? "0");

        int[][] MashtabArrayResult = MashtabArray(filledArray, k);

        PrintArray(MashtabArrayResult, k);
    }
}