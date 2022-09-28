/* Задача 19

Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */


void Check(int num)
{

    if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
    {
        Console.WriteLine("Да число полиндром");
    }
    else
    {
        Console.WriteLine("Нет, число не явзяется полиндромом");
    }


}

Console.WriteLine("Введите 5 значное число");
int num = Convert.ToInt32(Console.ReadLine());

while (num < 10000 || num > 99999)
    {
        Console.WriteLine("Введите другое число");
        num = Convert.ToInt32(Console.ReadLine());
    }

while (num > 9999 && num <= 99999)
{
    Check(num);
    Console.WriteLine();

break;
    

}






