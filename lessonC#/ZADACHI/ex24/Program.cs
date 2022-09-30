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
        array[i] = i;
    }
}

string Print(int[] array)   // печать массива
{
    return "[" + String.Join(",", array) + "]";
}


double Cubb(int number)  // нахождение кубов
{

    double[] res = new double[number];
    for (int i = 1; i < number; i++)
    {
        res[i] = Math.Pow(i + 1, 3);
    }
    return res[number];
}


Console.WriteLine(" Введите число N :");
int number = Convert.ToInt32(Console.ReadLine());
int size = number + 1;
int[] arr = Create(size);
Fill(arr);
Console.WriteLine("Таблица чисел от 1 до N :");
Console.WriteLine(Print(arr));
Console.WriteLine("Таблица кубов от 1 до N :");
//Console.WriteLine(String.Join("," , Cubb()));

Console.WriteLine(Cubb(number));


