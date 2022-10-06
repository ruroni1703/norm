// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

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
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine("Чисел больше 0: " + count);
}
Task();