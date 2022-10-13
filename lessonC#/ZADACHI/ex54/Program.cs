// 54 Задайте двумерный массив
// Найти сумму элементов находящихся на главной диагонали
// (с индексами 0,0   (1,1) и тд)

void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colums = rows;   // так как надо квадратный массив
    Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,] matrix = new int[rows, colums];
    int sum = 0;
    Console.WriteLine("Исходный массив :");
    FillArray(matrix);
    PrintArray(matrix);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if (i == j)
            {
                sum = sum + matrix[i, j];
            }
        }
    }
    Console.WriteLine("Сумма элементов равна :");
    Console.WriteLine(sum);
    
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
            matrix[i, j] = i + j;
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


Zadacha54();