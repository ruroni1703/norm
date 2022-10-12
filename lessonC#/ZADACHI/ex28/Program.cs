// 28 Подсчитать сумму цифр в числе

int number = 1876;
int sum = 0;
while (number > 0)
{
    sum += number % 10;
    number /= 10;
}
Console.WriteLine($" сумма чисел в заданном числе равна {sum}");