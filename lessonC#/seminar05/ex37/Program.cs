﻿/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат запишите в новом массиве */

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
int[] MultiFirstLastNum(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 

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