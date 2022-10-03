// Задача 33 напишите программу, которая определяет присутствует ли заданное 
// число в массиве
// 4 массив [6,7,19,345,3] no
// 3 массив [6,7,19,345,3] yes

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
bool Check(int[] array, int arg)
{
    bool Checknum = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == arg)
        {
            Checknum = true;
            break;
        }

    }
    return Checknum;
}

Console.WriteLine("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(5, 1, 15);
Console.WriteLine();
Console.WriteLine("Создан случайный массив :");
PrintArray(arr);
bool check = Check(arr, number);
if (check) Console.Write("Да ");
else Console.Write("Нет ");