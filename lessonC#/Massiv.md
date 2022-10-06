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