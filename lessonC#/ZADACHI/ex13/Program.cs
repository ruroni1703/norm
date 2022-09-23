/* Выяснить, кратно ли число заданному, если нет, вывести остаток. */

Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());

bool isaliqot(int arg1, int arg2) // переводится как кратное
{
    return arg1 % arg2 == 0;
}

if (isaliqot(num1, num2)) Console.WriteLine($"{num1} кратно {num2}");
else Console.WriteLine($"{num1} не кратно {num2} Остаток {num1 % num2}");
