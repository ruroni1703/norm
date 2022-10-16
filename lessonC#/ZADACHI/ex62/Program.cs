//  62 В двумерном массиве целых чисел. Удалить строку и столбец,
//  на пересечении которых расположен наименьший элемент массива.
// пример
// 1472
// 5923
// 8424
// 5267

// на выходе получаем
// 923
// 424
// 267

void Zadacha62()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colums = random.Next(4, 8);
    Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,] matrix = new int[rows, colums];

    Console.WriteLine("Исходный массив :");
    FillArray(matrix);
    PrintArray(matrix);
    
    int min = matrix[0, 0];
    int i_min = 0;
    int j_min = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if (matrix[i, j] <min)
            {
                min = matrix[i,j];
                i_min = i;
                j_min = j;
            }   
        }
    }
    Console.WriteLine($"N[{i_min}, {j_min}] = {min}");

    int rowsResult = rows -1;
    int columsResult = colums -1;
    int[,] result = new int[rowsResult,columsResult];
    int bias_i = 0;  // переменная для смещения
    int bias_j = 0;
    for (int i = 0; i < rowsResult; i++)
    {
        if (i ==i_min) bias_i++;
        bias_j = 0;   //каждый раз обнуляем перед новой строкой
        for (int j = 0; j < columsResult; j++)
        {
            if (j ==j_min) bias_j++;
            result[i,j] = matrix[i + bias_i, j + bias_j];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Новый массив с удалением строки и столбца");
    PrintArray(result);

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
            matrix[i, j] = random.Next(-100, 100);
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

Zadacha62();