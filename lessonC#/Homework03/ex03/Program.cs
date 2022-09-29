// /* Задача 23
// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125   мое решение, таблица кубов вроде выходит 
//но не получается заполнить числами от 1 до заданного, 
//и начинается с нуля все, так и не смог разобраться() */   

Console.Clear();
Console.WriteLine("Введите число n:");
int number = Convert.ToInt32(Console.ReadLine());
// метод получения числа
int GetIntNum(int number)
{
       number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// создаем массив( с указанным количеством элементов)
int[] CreateArray(int size)
{
    size = number + 1;
    return new int[size];
}

//  метод заполнения массива 
void FillArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = number;
    }
  
}


//получение кубов чисел
void Create(int[] el)
{
    int number = el.Length;
    for (int i = 0; i < number; i++)
    {
        el[i] = i * i * i;
    }
}

// вывод исходных числе и кубов
int[] arr = FillArray(number);
Console.WriteLine($"Таблица чисел от 1 до {number} :");
Console.WriteLine(String.Join('|', arr));
Create(arr);
Console.WriteLine($"Таблица кубов чисел от 1 до {number} :");
Console.WriteLine(String.Join('|', arr));


