 //34 Написать программу замену элементов массива на противоположные

 void Zadacha34()
 {
    int size = 12;
    int[] array = new int[size];
    FillArray(array);
    Console.WriteLine("Вывод массива ");
    PrintArray(array);
    ChangeValue(array);
    Console.WriteLine("Вывод массива с заменой элементов на противоположные ");
    PrintArray(array);
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
    
    Console.WriteLine("[" + String.Join(",", array) + "]");

}

void ChangeValue(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
}


Zadacha34();