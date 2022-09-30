// 37 В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 

//1 создать массив
// 2 заполнить массив числами
// 3 печать массива
// 4 финал

// 1
int[] Create(int len)
{
    return new int[len];
}

// 2
void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

//3 
string Print(int[] array)
{
    return "[" + String.Join("," , array) + "]";
}

// 4 
int Search(int[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] arr = Create(123); //создает массив с 123 элемента через метод
Console.WriteLine(Print(arr));
Fill (arr, 1, 200);  // заполняет массив числами от 1 до 200
Console.WriteLine(Print(arr));
Console.WriteLine(Search(arr));