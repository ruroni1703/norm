// 30 напишите программу которая задает массив из 8 случайных чисел
// и выводит отсортированный по модулю массив
// 6,1,-33 = [1.6.-33]


void Zadacha35()
{
    
    int size = 12;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    SortArray(array);

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

void SortArray(int[] array)  // сортировка массива
{
    for (int i = 1; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i; j++)
        {
            if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    PrintArray(array);
}
Zadacha35();