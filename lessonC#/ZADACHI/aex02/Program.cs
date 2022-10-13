// Дан двумерный массив из двух строк и 22 столбцов. В его первой строке записанно количество
// мячей, забитой футбольной командой в той или иной игре, во второй количество пропущенных
// в этой же игре. 
// а) Для каждой проведеннйо игры напечатать словесный результат выигрыш, ничья, или проигрыш
// б) определить количество выигрышей данной команды
// в)определить количество выгрышей и проигрышей данной команды
// г) определить количество выгрышей и проигрышей и ничьих данной команды
// д) определить в скольких играх разность пропущенных и забитых мячей была большей или равной трем
// е) определить общее число очков набранной командой( за выгрыш даются три очка, за ничью 1, 
// за проигрыш 0)

void Zadacha666()
{
    Random random = new Random();
    int rows = 2;
    int colums = 10;   
    Console.WriteLine($"Размер массива {rows}x{colums}");
    int[,] matrix = new int[rows, colums];
    FillArray(matrix,0 , 10);
    PrintArray(matrix);
    int win = 0;
    int lose = 0;
    int draw = 0;
    int points = 0;
    
        for (int i = 0; i < colums; i++)
        {
            if (matrix[0, i] > matrix[1, i])
            {
                win++;
                Console.WriteLine($"Победа {matrix[0, i]} : {matrix[1, i]}" );
            }
            if (matrix[0, i] < matrix[1, i])
            {
                
                lose++;
                Console.WriteLine($"Проигрыш {matrix[0, i]} : {matrix[1, i]}" );
            }
            if (matrix[0, i] == matrix[1, i])
            {
                draw++;
                Console.WriteLine($"Ничья {matrix[0, i]} : {matrix[1, i]}" );
            }
        }
        Console.WriteLine("Количество побед: " + win);
        Console.WriteLine("Количество поражений: " + lose);
        Console.WriteLine("Количество ничьих: " + draw);
        points = win*3 + draw;
        Console.WriteLine("Количество очков команды: " + points);
    

}

void FillArray(int[,] matrix, int minBalls = 0, int maxBalls = 1) // метод заполнения массива
{
    maxBalls++;
    Random random = new Random();
    int rows = matrix.GetLength(0);
    int colums = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = random.Next(minBalls, maxBalls);
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}



Zadacha666();