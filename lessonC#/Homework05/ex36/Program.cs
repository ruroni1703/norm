/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

// 1 2 3 создать, заполнить, распечатать
// 4 создать массив из нечетных элементов
// 5 найти их сумму

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);

    }
    return arr;
}

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

// void Sum(int[] array)  //метод для суммы не вызывается()
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i = i + 2)
//     {
//         sum = sum + array[i];
//     }
    
// }

int[] arr = CreateArray(4, 1, 5);
Console.WriteLine();
Console.WriteLine("Создан случайный массив :");
PrintArray(arr);
int[] newarr = CreateArray(4, 1, 5);
int sum = 0;
for (int i = 1; i < newarr.Length; i = i + 2)
{
    sum = sum + arr[i];
}
Console.WriteLine("Сумма элементов на нечетных позициях равна :");
Console.WriteLine(sum);
//int[] newarr = Sum();
// Console.WriteLine("Сумма элементов на нечетных позициях равна :");
// Console.WriteLine(newarr);