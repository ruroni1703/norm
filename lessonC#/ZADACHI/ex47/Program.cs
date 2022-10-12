// 47 Написать программу которая будет создавать копию заданного массива
// с помощью поэлементного копирования

void Zadacha47()
{
    int size = 10;
    int[] numbers = new int[size];
    int[] coppynumbers = new int[size];
    FillArray(numbers, -10, 10);
    PrintArray(numbers);
    for (int i = 0; i < size; i++)
    {
        coppynumbers[i] = numbers[i];
    }
    PrintArray(coppynumbers);

}

void FillArray(int[] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    int size = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    Console.WriteLine("Вывод массива ");
    Console.WriteLine("[" + String.Join(",", numbers) + "]");

}



Zadacha47();