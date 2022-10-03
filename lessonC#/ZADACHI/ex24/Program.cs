// 24 Найти кубы чисел от 1 до N
// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


// 1 принимаем число
// 2 выводим массив от 1 до n
//распечатать
// 3 создать функцию нахождения кубов
// 4 распечатать таблицу
Console.Clear();
int[] Create(int number)      // создали массив
{

    return new int[number];
}

void Fill(int[] array)  // заполнение массива
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = i+1;           // заполняет массив с 1 до N
    }
}

string Print(int[] array)   // печать массива
{
    return "[" + String.Join(",", array) + "]";
}


int[] Cubb(int [] el)  // нахождение кубов
{

    int SIZE = el.Length;
    for (int i = 0; i < el.Length; i++)
    {
        el[i] = el[i] *el[i] *el[i];
    }
    return el;
}


Console.WriteLine(" Введите число N :");
int number = Convert.ToInt32(Console.ReadLine());
int size = number;
int[] arr = Create(size);
Fill(arr);
Console.WriteLine("Таблица чисел от 1 до N :");
Console.WriteLine(Print(arr));
int[] newarr = Cubb(arr);
Console.WriteLine("Таблица кубов от 1 до N :");
Console.WriteLine(Print(newarr));



