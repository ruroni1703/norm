// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Написать программу, которая в двумерном массиве заменяет строки на столбцы 
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

void Zadacha61()
{
    Random random = new Random();
    int rowsA = random.Next(3, 7);
    int columsA = random.Next(3, 7);

    int rowsB = columsA;
    int columsB = random.Next(3, 7);

    int[,] matrixA = new int[rowsA, columsA];
    int[,] matrixB = new int[rowsB, columsB];

    Console.WriteLine($"Размер Матрицы A {rowsA}x{columsA}");
    Console.WriteLine("Матрица A :");
    FillArray(matrixA);
    PrintArray(matrixA);
    Console.WriteLine($"Размер Матрицы B {rowsB}x{columsB}");
    Console.WriteLine("Матрица B :");
    FillArray(matrixB);
    PrintArray(matrixB);
    int[,] matrixC = new int[rowsA, columsB];
    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < columsB; j++)
        {
            for (int k = 0; k < rowsB; k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    Console.WriteLine("Матрица C после перемножения :");
    PrintArray(matrixC);
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

Zadacha61();