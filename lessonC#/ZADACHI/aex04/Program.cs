// Двумерный массив 5х 5 заполнен случайными нулями и еденицами. Игрок может ходть только
// по полям заполненными еденицами. Проверьте существует ли путь из точки
// [0,0] в точку [4.4] (эти поля требуется принудительно задать равными еденицами)



    Random random = new Random();
    int rows = 5;
    int colums = 5;
    Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,] map = new int[rows, colums];

    Console.WriteLine("Исходный массив :");
    FillArray(map);
    int i_max = rows - 1;
    int j_max = colums - 1;
                                                                                                                                        
    map[0, 0] = 1;
    map[4, 4] = 1;
    PrintArray(map);
    bool exit = false;
    FindPath(map);

    if (exit) Console.WriteLine("Выход есть");
    else Console.WriteLine(" выхода не существует");
    Console.WriteLine(" вывод массива с выходом");
    //FillArray(map);
    PrintArray(map);

    void FindPath(int[,] map, int i = 0, int j = 0)
    {
        if (i < 0 || i > i_max
            || j < 0 || j > j_max
            || map[i, j] == 0
            || map[i, j] == 2)      // когда ушли из точки 1 заменим на 2 и это будет значит что вернулись
        {
            return;
        }
        map[i, j] = 2; // задаем двуйку на то место где уже были
        if (i == i_max && j == j_max)
        {
            exit = true;
            return;
        }

        
        FindPath(map, i + 1, j);   // это возможные ходы вверх,низ,право,лево
        FindPath(map, i - 1, j);
        FindPath(map, i, j + 1);
        FindPath(map, i, j - 1);
    }



void FillArray(int[,] map) // метод заполнения массива
{
    Random random = new Random();
    int rows = map.GetLength(0);
    int colums = map.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            map[i, j] = random.Next(0, 2);
        }
    }
}

void PrintArray(int[,] map)
{
    int rows = map.GetLength(0);
    int colums = map.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(map[i, j] + "\t ");
        }
        Console.WriteLine();
    }
}

