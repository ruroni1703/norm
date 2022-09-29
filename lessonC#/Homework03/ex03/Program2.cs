// /* Задача 23
// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125   решение подсказали*/  

int number;

// метод получения числа
int GetIntNum(int number)
{
    Console.Write("Введите элемент массива: ");
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}

 // создаем массив( с указанным количеством элементов)
int[] CreateArray(int size)
{
    int[] array = new int[size];
    return array;
}

//  метод заполнения массива 
void FillArray(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        arr[i] = GetIntNum(number);
        i++;
    }
}


//получение кубов чисел
int[] Create(int[] el)
{
    int temp = el.Length;
    for (int i = 0; i < el.Length; i++)
    {
        el[i] = el[i] * el[i] * el[i];
    }
    return el;
}




Console.Write("Введите число n: ");
number = Convert.ToInt32(Console.ReadLine());


// Здесь мы создаем массив arr из number элементов, пока он будет заполнен нулями!
int[] arr = CreateArray(number);
// Заполняем массив данными с клавиатуры
FillArray(arr);
// Выводим массив в консоль
for(int i = 0; i < arr.Length; i++) {
    Console.Write($"{arr[i]}\t|"); Console.WriteLine($"Таблица чисел от 1 до {number}");
}
Console.WriteLine("\b"); // форматирование вывода

// Теперь нам остается ввести новый массив и вызвать метод Create;
int[] newArr = Create(arr);
for(int i = 0; i < newArr.Length; i++) 
{
    
    Console.Write($"{newArr[i]}\t|"); Console.WriteLine($"Таблица кубов от 1 до {number}");
}
Console.WriteLine("\b");