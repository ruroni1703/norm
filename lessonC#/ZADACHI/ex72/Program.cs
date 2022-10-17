// 72 Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
// Числа идут друг за другом без разделителей.

// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.

// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.

// Пример:

// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }

// выходные данные:
// 1, 7, 0, 1
// Какие ошибки могут возникнуть при обработке наборов данных?

// int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
// int[] info = { 2, 3, 3, 1 };
// int bias = 0; //сдвиг

// for (int i = 0; i < data.Length; i++)
// {
//     string numberstr = "";
//     for (int j = 0; j < data[i]; j++)
//     {
//         numberstr += info[j + bias];
//     }
//     Console.WriteLine(numberstr);
//     bias += data[i];
// }


 using System;

namespace Project
{
    class Program
    {

        static void Main(string[] args)
        {

            //Заданы 2 массива: info и data. В массиве info хранятся двоичные представления
            //нескольких чисел (без разделителя). В массиве data хранится информация
            //о количестве бит, которые занимают числа из массива info.
            //Напишите программу, которая составит массив десятичных представлений
            //чисел массива data с учётом информации из массива info.

            Random random = new Random();
            int sizeData = random.Next(4, 11);
            int[] data = new int[sizeData];
            FillArray(data, 1, 10);
            int sizeInfo = 0;
            for (int i = 0; i < sizeData; i++)
            {
                sizeInfo += data[i];
            }

            int[] info = new int[sizeInfo];
            FillArray(info, 0, 1);
            PrintArray(data);
            PrintArray(info);

            int bias = 0;

            for (int i = 0; i < data.Length; i++)
            {
                string numberStr = "";
                for (int j = 0; j < data[i]; j++)
                {
                    numberStr += info[j + bias];
                }               
                int number = Convert.ToInt32(numberStr);
                Console.Write(number + " -> ");
                int result = ConvertFromBin(number, numberStr.Length);
                Console.WriteLine(result);
                bias += data[i];
            }

            int ConvertFromBin(int number, int length)
            {
                int result = 0;
                for (int j = 0; j < length; j++)
                {
                    result += number % 10 * PowerOfTwo(j);
                    number /= 10;
                }
                return result;
            }

            int PowerOfTwo(int n)
            {
                int result = 1;
                for (int i = 1; i <= n; i++) result *=2;
                return result;
            }


        }


        #region Fill & Print
        static void FillArray(int[] numbers,
                       int minValue = 0,
                       int maxValue = 9)
        {
            maxValue++;
            int size = numbers.Length;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }
        }


        static void PrintArray(int[] numbers)
        {
            int size = numbers.Length;
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + "  ");
            }
            Console.WriteLine();
        }

        static void FillArray(double[] numbers,
            int minValue = 0,
            int maxValue = 9)
        {
            maxValue++;
            int size = numbers.Length;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                double value = random.NextDouble() * 20 - 10;
                numbers[i] = Math.Round(value, 2);
            }
        }

        static void PrintArray(double[] numbers)
        {
            int size = numbers.Length;
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + "  ");
            }
            Console.WriteLine();
        }
        static void FillArray(
            int[,] array,
            int startNumber = 0,
            int finishNumber = 10
        )
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            Random random = new Random();
            finishNumber++;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(startNumber, finishNumber);
                }
            }
        }

        static void FillArray(double[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 2);
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }

        static void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        #endregion


    }
}
