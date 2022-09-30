// 25 Найти сумму чисел от 1 до А

Console.Write("введите число : ");
int x = Convert.ToInt32(Console.ReadLine());
int a = 1;
int sum = 0;
while (a <= x)
{
    sum = sum +a;
    a++;
}
Console.WriteLine(sum);