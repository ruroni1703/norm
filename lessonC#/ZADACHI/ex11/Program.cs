// написать программу , которая принимает на вход трехзначное число
// и на выходе выходит перевернутое число

int number = 157;
int result = number % 10;
if (number > 99 && number < 1000)
{
    result = number % 10 * 100 + number /10%10 * 10 + number/100;
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}

Console.WriteLine(result);