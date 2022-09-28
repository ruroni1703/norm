/* 22 Найти расстояние между точками в пространстве 2D
A (3, 6) B (2, 1) = 5.09
A (7 ,-5) B (1, -1) = 7.21 */

Console.WriteLine("Введите координату x для первой точки : ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для первой точки : ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x для второй точки : ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для второй точки : ");
int yb = Convert.ToInt32(Console.ReadLine());

double X = Math.Sqrt((xb - xa)^ 2 + (yb - ya)^ 2);
Console.WriteLine($"Расстояние между точками равно {X} ");