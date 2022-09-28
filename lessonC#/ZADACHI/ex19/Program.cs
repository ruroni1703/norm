// 19 Определить номер четверти плоскости, в которой находится 
// точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X == 0 || Y == 0)
{
    Console.WriteLine("Введите другую координату!!!");
}
else if (X > 0 && Y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}
