// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



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

int FindMax(int Max, int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];

        }
    }
    return max;
}

int FindMin(int Min, int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];

        }
    }
    return min;
}
int[] arr = { 3, 7, 22, 2, 78 };
Console.WriteLine();
Console.WriteLine("Создан  массив :");
PrintArray(arr);
int max = 0;
int min = 0;

int imax = FindMax(max, arr);
Console.WriteLine("максимальное значение в массиве :");
Console.WriteLine(imax);
int imin = FindMin(min, arr);
Console.WriteLine("минимальное значение в массиве :");
Console.WriteLine(imin);
int result = imax - imin;
Console.WriteLine("Разница между максимальным значением и минимальным равна :");
Console.WriteLine(result);