//72 Написать программу возведения числа А в целую стень B с помощью рекурсии


void Zadacha72()
{
    int a = 5;
    int b = 4;
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    Console.WriteLine($"{a}^{b} = {result}");
    Pow(a, b);
}


void Pow(int a, int b, int result = 1)
{
    if (b == 0)
    {
        Console.WriteLine(result);
        return;
    }
    result *= a;
    b--;
    Pow(a, b, result);
}

Zadacha72();