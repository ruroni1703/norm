// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Zadacha60()
{
    // Random random = new Random();
    // int rows = 2;
    // int colums = 2;
    // int 
    // Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,,] matrix = new int[2, 2, 2];

    Console.WriteLine("Исходный массив :");
    FillArray(matrix);
    PrintArray(matrix);



}

void FillArray(int[,,] matrix) // метод заполнения массива
{
    Random random = new Random();
    // int rows = matrix.GetLength(0);
    // int colums = matrix.GetLength(1);

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                matrix[i, j, k] = random.Next(0, 100);
            }
        }
    }
}

void PrintArray(int[,,] matrix)
{
    // int rows = matrix.GetLength(0);
    // int colums = matrix.GetLength(1);
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.Write(matrix[i, j, k] + "\t ");
            }
        }
        Console.WriteLine();
    }
}

Zadacha60();