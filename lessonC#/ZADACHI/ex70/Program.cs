// 70 Найти сумму цифр числа

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" сумма цифр в числе {n} =:");
Console.WriteLine(SumNum(n));


int SumNum(int n, int sum = 0)
{
   
    if (n == 0)
    {
        return sum;
    }

    sum+= n%10;
    n = n/10;
    return SumNum(n, sum);
}