//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// 1 создать массив 
// 2 заполнить случайными положительными трехзначными числами
// 3 распечатать
// 4 показать массив из четных чисел
// 5 распечатать этот массив

//1
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

int [] SearchPositiveArray(int[] array)
{
      int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) count ++;


    }
    return;
}


    int[] arr = CreateArray(15, 100, 1000);
    Console.WriteLine();
    //Console.WriteLine(String.Join('|', arr));
    PrintArray(arr);
    int[] SearchPositiveArray = SearchPositiveArray(arr);