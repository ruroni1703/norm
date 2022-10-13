// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

void Zadacha50()
{
    Random random = new Random();
    int rows = random.Next(3, 5);
    int colums = random.Next(3, 5);
    Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,] matrix = new int[rows, colums];
    Console.WriteLine("Исходный массив :");
    FillArray(matrix);
    PrintArray(matrix);

    Console.WriteLine("Введите строку искомого элемента в массиве:");
    int positionrow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец искомого элемента в массиве:");
    int positioncolums = Convert.ToInt32(Console.ReadLine());

    if 
    (positionrow < matrix.GetLength(0) && positioncolums < matrix.GetLength(1) 
    && positionrow > 0 && positioncolums > 0)
    {
        Console.WriteLine($"Такой элемент есть и он равен: {matrix[positionrow, positioncolums]}");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
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
            matrix[i, j] = random.Next(1, 10);
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

Zadacha50();