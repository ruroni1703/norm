// Показать вторую цифру трёхзначного числа
// через метод

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100) Console.WriteLine("В числе нету третьей ифры");

int ThirdNum(int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    int third = number % 10;
    return third;
}

Console.WriteLine($" Третья цифра числа {a} равна {ThirdNum(a)} ");
