/* Напишите программу которая выводит случайное число из отрезка [10,99] 
и показывает наибольшую цифру этого числа
78-8
12-2 */

Console.Clear();
int n = new Random().Next(10, 100);
Console.WriteLine("Загадано число :");
Console.WriteLine(n);
int a = n / 10;
int b = n % 10;

Console.WriteLine("Максимальное цифра");
if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}