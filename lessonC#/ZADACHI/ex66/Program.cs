// 66 Показать натуральные числа от 1 до N, N задано 5/6

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

FindNatural(n);
void FindNatural(int n, int a = 0)
{
    n++;
    Console.WriteLine(a);
    if (a >= n)
    {
        return;
    }
 
    FindNatural(n,a);
}

// n--
// Console.WriteLine(n)  // если надо вывести числа от N до 1