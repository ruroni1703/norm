//Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива

void Zadacha33()
{
    int size = 12;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("Сумма положительных элементов : ");
    Console.WriteLine(SummPositive(array));
    Console.WriteLine("Сумма отрицательных элементов : ");
    Console.WriteLine(SummNegative(array));
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива ");
    Console.WriteLine("[" + String.Join(",", array) + "]");

}

int SummPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        sum += array[i];  
    }
    return sum;
}

int SummNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        sum += array[i];  
    }
    return sum;
}

Zadacha33();