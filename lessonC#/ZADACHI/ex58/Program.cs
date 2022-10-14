// Написать программу, которая в двумерном массиве заменяет строки на столбцы 
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

void Zadacha58()
{
    Random random = new Random();
    int rows = random.Next(3, 6);
    int colums = random.Next(3, 6);
    Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,] matrix = new int[rows, colums];

    Console.WriteLine("Исходный массив :");
    FillArray(matrix);
    PrintArray(matrix);

    if (rows == colums)
    {

        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < colums; j++)   // так как перебор начинается с I а не с нуля
            {

                (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);


            }
        }
        Console.WriteLine("Новый массив с заменой переменных :");
        PrintArray(matrix);
    }
    else
    {
        Console.WriteLine("Матрица не квадратная, поменять нельзя");
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

Zadacha58();