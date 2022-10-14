// 56 Задайте двумерный массив. Написать программу которая поменяет 
// местами первую и послежнию строку массива

void Zadacha56()
{
    Random random = new Random();
    int rows = random.Next(3, 5);
    int colums = random.Next(3, 5);
    Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,] matrix = new int[rows, colums];

    Console.WriteLine("Исходный массив :");
    FillArray(matrix);
    PrintArray(matrix);

    int min_i = 0;
    int max_i = rows - 1;


    for (int j = 0; j < colums; j++)
    {
        (matrix[min_i, j], matrix[max_i, j]) = (matrix[max_i, j], matrix[min_i, j]);
    }
    Console.WriteLine("Новый массив с заменой переменных :");
    PrintArray(matrix);
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

Zadacha56();