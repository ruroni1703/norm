// 27 Определить количество цифр в числе

Console.Write("введите число : ");
int x = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (x > 0)
{
    x = x/10;
    index++;
}
Console.WriteLine(index);