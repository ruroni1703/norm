// 41 Выяснить являются ли три числа сторонами треугольника.
// может ли существовать треугольник с такиими сторонами
// ( использовать теорему о неравенстве треугольника : каждая сторона треугольника
// меньше суммы двух других сторон)

void Zadacha41()
{
    Console.WriteLine("Введите сторону a :");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите сторону b :");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите сторону c :");
    int c = Convert.ToInt32(Console.ReadLine());
    
    if (a+b > c && a+c > b && b+c >a)
    {
        Console.WriteLine("Такой треугольник может быть ");
    }
    else
    {
        Console.WriteLine("Такого Треугольника не может быть ");
    }

}

Zadacha41();