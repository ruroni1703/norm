// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = new int[3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

int n = 4;
int m = 3;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}


for (int k = 0; k < m; k++)
{
    for (int i = 0; i < n; i++)    // сортирует одну строчку массива,чтобы и столбцы добавляем k и еще один цимкл
    {
        for (int j = 0; j < n - 1; j++)
        {
            if (matrix[k, j] < matrix[k, j + 1])
            {
                int temp = matrix[k, j];
                matrix[k, j] = matrix[k, j + 1];
                matrix[k, j + 1] = temp;
            }
        }
    }
}

Console.WriteLine();

for (int i = 0; i < m; i++)   // печать
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
