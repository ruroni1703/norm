// 71 Написать программу вычисления функции Аккермана
//с помощью рекурсии даны два числа  m, newm=2 n = 3 A(m,n) = 29

void ZadachaAkkerman()
{
    Console.WriteLine("Введите число m :");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n :");
    int n = Convert.ToInt32(Console.ReadLine());
    Akker(m, n);
    Console.WriteLine(Akker(m,n));



}

int Akker(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akker(m - 1, 1);
    if (m > 0 && n > 0) return Akker(m - 1, Akker(m, (n - 1)));
    return Akker(m, n);
}
ZadachaAkkerman();