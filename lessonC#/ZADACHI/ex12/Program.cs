/* Напишите программу,которая выводит случайное трехзначное число и удаляет вторую цифру
этого числа
456 -46
782
918 */

int number = new Random().Next(100, 1000);
int removenimber(int num)
{
    int lastnumber = num % 10;
    int firstnumber = num / 100;
    return firstnumber * 10 + lastnumber;
}
int result = removenimber(number);
Console.WriteLine($"Итоговое число от {number} равно { result } ");