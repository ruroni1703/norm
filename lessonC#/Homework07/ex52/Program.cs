// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(3, 5);
    int colums = random.Next(3, 5);
    Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,] matrix = new int[rows, colums];

    Console.WriteLine("Исходный массив :");
    FillArray(matrix);
    PrintArray(matrix);

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sumSrAr = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumSrAr = sumSrAr + matrix[i, j];

        }
        double result = sumSrAr / matrix.GetLength(1);
        Console.WriteLine($"Средне арифмитическое столбца {j} :");
        Console.WriteLine(Math.Round(result, 2));
    }

}

void FillArray(int[,] matrix) // метод заполнения массива
{
    Random random = new Random();
    int rows = matrix.GetLength(0);
    int colums = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = random.Next(0, 11);
        }
    }
}

void PrintArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int colums = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(matrix[i, j] + "\t ");
        }
        Console.WriteLine();
    }
}


Zadacha52();