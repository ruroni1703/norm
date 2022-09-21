Console.Clear();
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < n+1)

{
    Console.WriteLine(i * i);
    i++;
}