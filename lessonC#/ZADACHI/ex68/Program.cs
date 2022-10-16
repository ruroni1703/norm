//68 Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

FindNatural(n,m);
void FindNatural(int n, int a = 1)
{
   
    Console.WriteLine(a);
     a++;
    if (a >= n)
    {
        return;
    }
 
    FindNatural(n,a);
}