/* Задача 10: Напишите программу, 
которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру
 этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите число :");
int n = Convert.ToInt32(Console.ReadLine());

int a = n / 10;
int b = a % 10;

Console.WriteLine("Вторая цифра числа :");
Console.WriteLine(b);