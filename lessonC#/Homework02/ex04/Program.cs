/* Задача 228: Напишите программу, которая принимает на вход семь чисел, и находит 
их среднее арифметическое
1 2 3 4 5 6 7-> 4
10 20 30 40 50 60 70 -> 40 */

int i = 1;
float total = 0;
int count = 0;

while (i < 8)
{
    Console.WriteLine("Введите число №" + i +" ");
    count = Convert.ToInt32(Console.ReadLine());
    total = total + count;
    i++;
}

total = total / 7;
Console.WriteLine("Среднее арифметическое равно :");
Console.WriteLine(total);