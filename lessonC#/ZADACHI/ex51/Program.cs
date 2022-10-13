// 51 Задать двумерный массив размера m на n
// где каждый элемент находится по формуле  A = i + j
// вывести его на экран
// m = 3 n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


void Zadacha51()
{
    Random random = new Random();
    int m = random.Next(4, 8);
    int n = random.Next(4, 8);
    Console.WriteLine($"Размер массива {m}x{n}");
    int[,] matrix = new int[m, n];
    FillArray(matrix);
    PrintArray(matrix);
}

void FillArray(int[,] matrix) // метод заполнения массива
{
    Random random = new Random();
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = i + j;
        }
    }
}

void PrintArray(int[,] matrix)
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


Zadacha51();