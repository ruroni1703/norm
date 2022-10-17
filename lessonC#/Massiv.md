Создается случайный массив и распечатывается
int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);

    }
    return arr;
}
// 3
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]},");
        else
            Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");

}

int[] arr = CreateArray(15, 100, 1000);
Console.WriteLine();
Console.WriteLine("Создан случайный массив :");
PrintArray(arr);




double[] CreateAndFillArray()   // метод создания и наполнения массива
{
    //Random rmd = new Random();                      // если заполнение масссива рандомными числами
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    // for (int i = 0; i < array.Length; i++)
    // {
    //     array[i] = rmd.Next(-100, 101);
    // }
    // return array;

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива №{i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.WriteLine("[" + String.Join(",", array) + "]");
    // Console.Write("[");                      // та же запись но длинная
    // for (int i = 0; i < array.Length; i++)
    // {
    //     if (i < array.Length - 1)
    //         Console.Write($"{array[i]},");
    //     else
    //         Console.Write($"{array[i]}");
    // }
    // Console.WriteLine("]");
}

void Task()
{
    Console.Clear();
    Console.Write("Введите размер массива: ");
    double[] array = CreateAndFillArray();
    PrintArray(array);
}
Task();



Примеры заполнения одномерного и двумерного массивов
#region Fill & Print
        static void FillArray(int[] numbers,
                       int minValue = 0,
                       int maxValue = 9)
        {
            maxValue++;
            int size = numbers.Length;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }
        }


        static void PrintArray(int[] numbers)
        {
            int size = numbers.Length;
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + "  ");
            }
            Console.WriteLine();
        }

        static void FillArray(double[] numbers,
            int minValue = 0,
            int maxValue = 9)
        {
            maxValue++;
            int size = numbers.Length;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                double value = random.NextDouble() * 20 - 10;
                numbers[i] = Math.Round(value, 2);
            }
        }

        static void PrintArray(double[] numbers)
        {
            int size = numbers.Length;
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + "  ");
            }
            Console.WriteLine();
        }
        static void FillArray(
            int[,] array,
            int startNumber = 0,
            int finishNumber = 10
        )
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            Random random = new Random();
            finishNumber++;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(startNumber, finishNumber);
                }
            }
        }

        static void FillArray(double[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 2);
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }

        static void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        #endregion