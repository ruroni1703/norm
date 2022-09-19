void FillArray(int[] collection) // collection это какой-то аргумент
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // запускает рандомный массив от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)    // col это уже второй аргумент
{
    int count = col.Length; // длина масива
    int position = 0;  //   это индекс но подругому
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count =collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}
int[] array = new int [10];   // определение массива из 10 элементов

FillArray(array); // этот метод заполнило массив
PrintArray(array); // этот метод функция распечатало этот массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);