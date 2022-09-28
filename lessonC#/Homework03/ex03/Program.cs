// /* Задача 23
// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125   мое решение, но не пойму что не так */   

// Console.Clear();
// Console.WriteLine("Введите число n:");
// int number = Convert.ToInt32(Console.ReadLine());
// // метод получения числа
// int GetIntNum(int number)
// {
//     Console.WriteLine("Введите число n:");
//     number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

//  // создаем массив( с указанным количеством элементов)
// int[] CreateArray(int size)
// {
//     size = number -1;
//     return new int[size];
// }

// //  метод заполнения массива 
// void FillArray(int[] array)
// {
//     int size = array.Length;
//     int i = 0;
//     while (i < size)
//     {
//         array[i] = GetIntNum(number);
//         i++;
//     }
// }


// //получение кубов чисел
// void Create(int[] el)
// {
//     int number = el.Length;
//     for (int i = 0; i < number; i++)
//     {
//         el[i] = i * i * i;
//     }
// }

// // вывод исходных числе и кубов
// int[] arr = CreateArray(number - 1);
// Console.WriteLine(String.Join(' ', arr));
// Create(arr);
// Console.WriteLine(String.Join(' ', arr));

