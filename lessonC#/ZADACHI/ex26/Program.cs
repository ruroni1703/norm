// 26 Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число a :");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b :");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= b; i++)
{
    result *= a;
}


Console.WriteLine($"число {a} в степени {b} равно {result}");
