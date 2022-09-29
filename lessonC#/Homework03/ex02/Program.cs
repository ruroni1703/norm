/* Задача 21

Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними 
в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

// через метод я не придумал как.....


Console.WriteLine("Введите координату x для первой точки : ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для первой точки : ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z для первой точки : ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x для второй точки : ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для второй точки : ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z для второй точки : ");
int zb = Convert.ToInt32(Console.ReadLine());





double X = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));


Console.WriteLine($"Расстояние между точками равно {X} ");