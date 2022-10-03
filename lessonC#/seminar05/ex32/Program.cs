//Задача 32: Напишите программу замена элементов массива: положительные элементы 
//замените на соответствующие отрицательные, и наоборот.

// 1 создать массив и заполнить
// 2 распечатать
// 3 замена
// 4 распечатать получившиеся

Console.Clear();
//1 2
int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);

    }
    return arr;
}
// 2
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
// 3 
int[] InvertArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (- 1);

    }
    return array;
}


int[] arr = CreateArray(15, -99, 100);
Console.WriteLine();
Console.WriteLine("Создан случайный массив :");
PrintArray(arr);
int [] InvertArrayNum = InvertArray(arr);
Console.WriteLine("Массив с заменой положительных на отрицательные и наоборот :");
PrintArray(InvertArrayNum);
