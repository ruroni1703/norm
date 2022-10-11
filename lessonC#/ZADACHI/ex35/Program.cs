// 35
//Определить, присутствует ли в заданном массиве, некоторое число

void Zadacha35()
{
    Console.WriteLine("Введите число для поиска : ");
    int check = Convert.ToInt32(Console.ReadLine());
    int size = 12;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    CheckValue(array, check);
    
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

void CheckValue(int[] array, int check)
{
    bool flag = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (check == array[i])
        {
            flag = true;
        }
    }
    if (flag == true)
    Console.WriteLine($" Число {check} находится в массиве");
    else
    Console.WriteLine($" Число {check}  не находится в массиве");
}
Zadacha35();