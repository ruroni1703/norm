// 66 Показать натуральные числа от 1 до N, N задано 5/6

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

FindNatural(n);
void FindNatural(int n, int a = 0)
{
    a++;
    Console.WriteLine(a);
    if (a >= n)
    {
        return;
    }
 
    FindNatural(n,a);
}