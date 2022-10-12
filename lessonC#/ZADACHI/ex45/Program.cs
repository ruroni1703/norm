// 45
// Показать первые N чисел Фибоначчи не используя рекурсию

void Zadacha45()
{
    Console.WriteLine("Введите N чисел Фибоначи: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int a = 0;
    int b = 1;
    int[] numbers = new int[size];
    numbers[0] = a;
    numbers[1] = b;
    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i - 2] + numbers[i - 1];
    }
    PrintArray(numbers);
}

void PrintArray(int[] numbers)
{
    Console.WriteLine("Вывод массива ");
    Console.WriteLine("[" + String.Join(",", numbers) + "]");

}

Zadacha45();