 // Дан массив, нужносформировать новый массив 
//из четных чисел

// 1 Описать метод(функцию) получения псевдослучайного числа от Min до max
// 2 Описать метод(функцию) создающую массив( с указанным количеством элементов)
// 3 Описать метод(функцию) заполнения псевдослучайными числами
// 4 Описать метод(функцию) распечатывания массива
// 5 Описать метод(функцию) нахождения четных числе в массиве
// 6 Описать метод(функцию) финального решения

// 1 Описать метод(функцию) получения псевдослучайного числа от Min до max
int GetIntArray(int min, int max)
{
    int value = new Random().Next(min, max);
    return value;
}

// 2 Описать метод(функцию) создающую массив( с указанным количеством элементов)
int[] CreateArray(int size)
{
    return new int[size];
}

// +3 Описать метод(функцию) заполнения псевдослучайными числами
void Fill(int[] array)
{
    int size = array.Length;
    int i = 0;

    while (i < size)
    {
        array[i] = GetIntArray(1, 10);
        i++;
    }
}

// 4 Описать метод(функцию) распечатывания массива
void Print(int[] array)
{
    int i = 0;
    int size= array.Length;
    while (i < size)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}

// 5 Описать метод(функцию) нахождения четных числе в массиве
int SearchNumberEvenElements(int[] array) // здесь не void так как идет поиск и каждый раз с нуля пока все не переберет
{
    int count = 0;
    int size = array.Length;
    int i = 0;
    while (i < size)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
        i++;
    }
    return count;
}

// 6 Описать метод(функцию) финального решения
int[] Final(int[] data, int count)
{
    int[] evenItems = new int[count];
    int position= 0;
    int i = 0;
    int size = data.Length;

    while (i< size)
    {
        if (data[i] % 2 == 0)
        {
            evenItems[position] = data[i];
            position += 1;
        }
        i += 1;
    }
    return evenItems;
}

int Length = GetIntValue(10, 20);
int[] col = CreateArray(Length);
Print(col);
Fill(col);
Print(col);
int count = SearchNumberEvenElements(col);
int[] result = Final(col, count);
Print(result);