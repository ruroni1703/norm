// 52 В двумерном массиве найти заменить элементы, у которых оба индекса чётные 
// и заменить их на их квадраты

void Zadacha52()
{
    Random random = new Random();
    int m = random.Next(4, 8);
    int n = random.Next(4, 8);
    Console.WriteLine($"Размер массива {m}x{n}");
    int[,] matrix = new int[m, n];
    Console.WriteLine("Исходный массив :");
    FillArray(matrix);
    PrintArray(matrix);
    FillArraySqrt(matrix);
    Console.WriteLine("Массив с заменой элементов квадратами массив :");
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

void FillArraySqrt(int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);

    for (int i = 0; i < m; i +=2)
    {
        for (int j = 0; j < n; j +=2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
}
Zadacha52();