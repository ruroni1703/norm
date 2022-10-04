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

int FindMax(int max)
{
    int i = 0;
    int max = 0;
    while ()
    
}

int[] arr = {3,7,22,2,78};
Console.WriteLine();
Console.WriteLine("Создан  массив :");
PrintArray(arr);
int[] oddArray = OddArray(arr);
Console.WriteLine("новый массив :");
PrintArray(oddArray);