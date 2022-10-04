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

// int[] array = { 1, 9, 9, 0, 2, 8, 0, 9 };
// int count1 = 0;
// for (int i = 0; i < array.Length; i++)
// {
    
//     if (array[i] == 0)
//     {
//         count1++;
//     }
// }
// Console.Write("0 встречается ");
// Console.WriteLine(count1);
// int count2 = 0;
// for (int i = 0; i < array.Length; i++)
// {
    
//     if (array[i] == 1)
//     {
//         count2++;
//     }
// }
// Console.Write("1 встречается ");
// Console.WriteLine(count2);

// int count3 = 0;
// for (int i = 0; i < array.Length; i++)
// {
    
//     if (array[i] == 2)
//     {
//         count3++;
//     }
// }
// Console.Write("2 встречается ");
// Console.WriteLine(count3);

// int count4 = 0;
// for (int i = 0; i < array.Length; i++)
// {
    
//     if (array[i] == 8)
//     {
//         count4++;
//     }
// }
// Console.Write("8 встречается ");
// Console.WriteLine(count4);

// int count5 = 0;
// for (int i = 0; i < array.Length; i++)
// {
    
//     if (array[i] == 9)
//     {
//         count5++;
//     }
// }
// Console.Write("9 встречается ");
// Console.WriteLine(count5);

int[] arr = {0,2,3,4,6,9,6,7,5,2,7,9};

int[] count = new int[arr.Max() + 1];

for (int i = 0; i < arr.Length; i++)
{
    count[arr[i]]++;
}
for (int i = 0; i < count.Length; i++)
{
    if (count[i] != 0)
    {
        Console.WriteLine($"{i} встречается {count[i]} раз");
    }
}