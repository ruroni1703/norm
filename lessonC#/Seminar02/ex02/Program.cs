/* Определить присутствует ли в заданном массиве
некоторое число */

Console.Clear();
int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0;
Console.Write("ищем число =");
Console.WriteLine(find);
Console.WriteLine("заданный массив :");

while (index < count)
{
    array[index] = new Random().Next(1, 101);
    Console.Write(array[index] + " ");
    index++;
}

index = 0;
bool element = false;

while (index < count)
{
    if (array[index] == find)
    {
        element = true;
    }
    index++;
}

if (element == true)
{
    Console.WriteLine("\nТакой элемент есть");
}
else
{
    Console.WriteLine("\nТакого элемента нет");
}


Console.WriteLine("\nEND");
