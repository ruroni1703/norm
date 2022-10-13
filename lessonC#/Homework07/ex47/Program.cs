// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void Zadacha47()
{
    Random random = new Random();
    int m = random.Next(4, 8);
    int n = random.Next(4, 8);
    Console.WriteLine($"Размер массива {m}x{n}");
    double[,] matrix = new double[m, n];
    FillArray(matrix);
    PrintArray(matrix);
}

void FillArray(double[,] matrix, int min = -9, int max = 10) // метод заполнения массива
{
    Random random = new Random();
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round((random.NextDouble() * (max - min) + min), 1);
        }
    }
}

void PrintArray(double[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + "\t ");
        }
        Console.WriteLine();
    }
}


Zadacha47();
