/* // Дан массив, нужносформировать новый массив 
//из четных чисел

// 1 Задать количество элементов
// 2 Задать массивб в котором хранятся элементы
// 3 Заполнить массив случайными числами
// 4 Распечатать исходный массив
// 5 Найти количество четных чисел в исходном массиве
// 6 Задать массив в котором будут четные числа
// 7 Заполнить массив в котором будут четные числа
// 8 Распечатать массив в котором хранятся четные числа

#region
// 1 Задать количество элементов
int size = new Random().Next(10, 20);

// 2 Задать массивб в котором хранятся элементы
int[] source = new int[size];

// 3 Заполнить массив случайными числами
for (int i = 0; i < size; i ++)
{
    source[i] = new Random().Next(1, 10);
}


// 4 Распечатать исходный массив
for (int i = 0; i < size; i ++)
{
    Console.Write(source[i] + " ");
}

/*  если делать через цикл while то будет так
int i = 0;   
while (i< size)
{
    source[i] = new Random().Next(1, 10);
    Console.Write(source[i] + " ");
    i++;
} */
/* #endregion */

/* // 5 Найти количество четных чисел в исходном массиве
int count = 0;
for (int i = 0; i < size; i ++)
{
    if (source[i] % 2 == 0)
    {
        count++;
    }
}

// 6 Задать массив в котором будут четные числа
int[] evenitems = new int[count];

// 7 Заполнить массив в котором будут четные числа
int pos = 0;
for (int i = 0; i < size; i ++)
{
    if (source[i] % 2 == 0)
    {
        evenitems[pos] = source[i];
        pos++;
    }
}
Console.WriteLine();

// 8 Распечатать массив в котором хранятся четные числа
for (int i = 0; i < count; i ++)
{
    Console.Write(evenitems[i] + " ");
}
Console.WriteLine();  */