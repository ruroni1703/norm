// 57 Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
// 
void Zadacha57()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colums = random.Next(4, 8);
    Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,] matrix = new int[rows, colums];

    Console.WriteLine("Исходный массив :");
    FillArray(matrix);
    PrintArray(matrix);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < colums - j - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    (matrix[i, k], matrix[i, k + 1]) = (matrix[i, k + 1], matrix[i, k]);
                }
            }
        }
    }

    Console.WriteLine();
    PrintArray(matrix);
}

// void MinSumInArray(int[,] array)
// {
//     int[] sumArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumInRow = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumInRow += array[i, j];
//         }
//         sumArray[i] = sumInRow;
//     }

//     Console.WriteLine("Сумма чисел по рядам:");
//     for (int i = 0; i < sumArray.Length; i++)
//     {
//         Console.WriteLine($"{sumArray[i]} ");
//     }

//     int minRow = 0;
//     for (int i = 1; i < sumArray.Length; i++)
//     {
//         if (sumArray[i] < sumArray[minRow]) minRow = i;
//     }
//     Console.WriteLine($"Номер строки с наименьшей суммой: {minRow + 1}");
// }



void FillArray(int[,] matrix) // метод заполнения массива
{
    Random random = new Random();
    int rows = matrix.GetLength(0);
    int colums = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = random.Next(0, 10);
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

Zadacha57();