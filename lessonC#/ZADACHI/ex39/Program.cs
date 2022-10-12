// 39 напишите программу , которая перевернет одномерный массив
//( последний будет на первом, первый на последнем и наоборот)
// [1,2,3,4,5] == [5,4,3,2,1]

void Zadacha39()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 10);
    PrintArray(numbers);
    SortArray(numbers);
    PrintArray(numbers);

    
}

void FillArray(int[] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    int size = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(minValue,maxValue);
    }
}

void PrintArray(int[] numbers)
{
    Console.WriteLine("Вывод массива ");
    Console.WriteLine("[" + String.Join(",", numbers) + "]");

}

void SortArray(int[] numbers)  // сортировка массива
{
    int size = numbers.Length;
    int maxIndex = size -1;
    for (int i = 0; i < size/2; i++)
    {
        int temp = numbers[i];
        numbers[i] = numbers[maxIndex - i];
        numbers[maxIndex - i] = temp;
    }
    
}

Zadacha39();