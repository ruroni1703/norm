/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

/* int a = 989;
Console.WriteLine(a);
if (a<0) a =-a;
Console.WriteLine(a);
if (a >= 100)
{
    while( a < 999)
    {
        a = a / 10;
    }
    Console.WriteLine(a%10)
}
 */



Console.Clear();
Console.WriteLine("Введите число n :");
int n = Convert.ToInt32(Console.ReadLine());

if (-99 <= n && n <= 99)
{
    Console.WriteLine("Третьей цифры у числа нет");
}

else if (-999 <= n && n <= 999)
{
    int a = n % 10;
    if (a < 0) a = a* -1;
    Console.WriteLine("Третья цифра числа n :");
    Console.WriteLine(a);
}

else if (-9999 <= n && n <= 9999)                                                                                                                     
{
    int a = n % 100;
    int b = a / 10;
    if (b < 0) b = b* -1;
    Console.WriteLine("Третья цифра числа n :");
    Console.WriteLine(b);
}

else if (-99999 <= n && n <= 99999)
{
    int a = n % 1000;
    int b = a / 100;
    if (b < 0) b = b* -1;
    Console.WriteLine("Третья цифра числа n :");
    Console.WriteLine(b);
}

else if (-999999 <= n && n <= 999999)
{
    int a = n % 10000;
    int b = a / 1000;
    if (b < 0) b = b* -1;
    Console.WriteLine("Третья цифра числа n :");
    Console.WriteLine(b);
}

else if (-9999999 <= n && n <= 9999999)
{
    int a = n % 100000;
    int b = a / 10000;
    if (b < 0) b = b* -1;
    Console.WriteLine("Третья цифра числа n :");
    Console.WriteLine(b);
}

else if (-99999999 <= n && n <= 99999999)
{
    int a = n % 1000000;
    int b = a / 100000;
    if (b < 0) b = b* -1;
    Console.WriteLine("Третья цифра числа n :");
    Console.WriteLine(b);
}

else if (-999999999 <= n && n <= 99999999)
{
    int a = n % 1000000;
    int b = a / 100000;
    if (b < 0) b = b* -1;
    Console.WriteLine("Третья цифра числа n :");
    Console.WriteLine(b);
}
