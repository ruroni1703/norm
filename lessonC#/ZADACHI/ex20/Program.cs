// S Задать номер четверти, показать диапазоны для возможных координат
 Console.Write("Введите номер четверти координат");
int num = Convert.ToInt32(Console.ReadLine());

if (num ==1)
{
    Console.WriteLine("Координаты X > 0 Y > 0");
}
if (num ==2)
{
    Console.WriteLine("Координаты X > 0 Y < 0");
}
if (num ==3)
{
    Console.WriteLine("Координаты X < 0 Y < 0");
}
if (num ==4)
{
    Console.WriteLine("Координаты X < 0 Y > 0");
}
if (num < 1 || num > 4)
{
    Console.WriteLine("Такой чертверти нет");
}

