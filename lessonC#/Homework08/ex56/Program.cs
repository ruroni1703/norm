// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
//  находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
//суммой элементов: 1 строка

void Zadacha56()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colums = random.Next(4, 8);
    Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,] matrix = new int[rows, colums];

    Console.WriteLine("Исходный массив :");
    FillArray(matrix);
    PrintArray(matrix);

    int sumMin = 0;
    int indexMin = 0;
    for (int j = 0; j < colums; j++)
    {
        sumMin += matrix[0, j];
    }


    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < colums; j++)
        {
            sum += matrix[i, j];

        }
        Console.WriteLine($"Сумма в {i + 1} строке равна : {sum} ");
        if (sum < sumMin)
        {
            sumMin = sum;
            indexMin = i;

        }

    }
    Console.WriteLine();
    Console.WriteLine($"самая минимальная сумма {sumMin} в строке {indexMin + 1}");
    
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

Zadacha56();