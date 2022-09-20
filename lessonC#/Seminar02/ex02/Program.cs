/* Определить присутствует ли в заданном массиве
некоторое число */

int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0;

while (index < count)
{
    array[index] = new Random().Next(1, 101);
    index++;
}

index = 0;

while (index < count)
{
    if (array[index] == find)
    {
        Console.WriteLine("ДА");
    }
    index++;
}

Console.WriteLine("END");
