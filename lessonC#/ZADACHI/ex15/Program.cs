/* Дано число. Проверить кратно ли оно 7 и 23
14 нет
46 нет
161 да */

/*  первый вариант
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0 ) Console.WriteLine($"{number} кратно");
else Console.WriteLine($"{number}  не кратно"); */

// второй вариант

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());


bool Multiplicity(int arg)
{
    return arg % 7 == 0 && arg % 23 == 0;
}

if (Multiplicity(number)) 
Console.WriteLine("да кратно");
else Console.WriteLine("Нет");
