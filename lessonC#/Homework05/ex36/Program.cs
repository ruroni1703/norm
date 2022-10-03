// /* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0 */

// // 1 2 3 создать, заполнить, распечатать
// // 4 создать массив из нечетных элементов
// // 5 найти их сумму

// int[] CreateArray(int size, int min, int max)
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);

//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1)  
//             Console.Write($"{array[i]},");
//         else
//             Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");

// }

// int[] OddArray(int[] el)
// {
//     int SIZE = el.Length;
//     for (int i = 1; i < el.Length; i+= 2)
//     {
//         el[i] = el[i];
//     }
//     return el;
// }

// int[] arr = CreateArray(4, -3, 10);
// Console.WriteLine();
// Console.WriteLine("Создан случайный массив :");
// PrintArray(arr);
// int[] oddArray = OddArray(arr);
// Console.WriteLine("новый массив :");
// PrintArray(oddArray);


// Составить частотный словарь элементов одномерного массива
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// ```
// частотный массив может быть представлен так:
// ```
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

int[] array = { 1, 9, 9, 0, 2, 8, 0, 9 };
int count1 = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] == 0)
    {
        count1++;
    }
}
Console.Write("0 встречается ");
Console.WriteLine(count1);
int count2 = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] == 1)
    {
        count2++;
    }
}
Console.Write("1 встречается ");
Console.WriteLine(count2);

int count3 = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] == 2)
    {
        count3++;
    }
}
Console.Write("2 встречается ");
Console.WriteLine(count3);

int count4 = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] == 8)
    {
        count4++;
    }
}
Console.Write("8 встречается ");
Console.WriteLine(count4);

int count5 = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] == 9)
    {
        count5++;
    }
}
Console.Write("9 встречается ");
Console.WriteLine(count5);