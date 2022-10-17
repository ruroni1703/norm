// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7     2-10 минут

void Zadacha62()
{
    Random random = new Random();
    int rows = 4;
    int colums = 4;
    Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,] matrix = new int[rows, colums];

    
    int index = 0;
    int currentRow = 0;    //текущая строка
    int currentColum = 0;
    int changeIndexRow = 0;
    int changeIndexColum = 1;
    int steps = colums; // шаги
    int turn = 0;   // поворот

    while (index < matrix.Length)
    {

        matrix[currentRow, currentColum] = index +1;
        //Console.Write(matrix[currentRow,currentColum] + " ");
        index++;
        steps--;    // шаги отнимаем
        if (steps == 0)
        {
            //if (turn % 2 == 0)                 // это условие если матрица не квадратная
            //steps = rows - 1 - turn/2;
            steps = colums - 1 - turn/2;
            int temp = changeIndexRow;
            changeIndexRow = changeIndexColum;
            changeIndexColum = -temp;
            turn++;
        }

        currentRow += changeIndexRow;
        currentColum += changeIndexColum;
    }
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

Zadacha62();