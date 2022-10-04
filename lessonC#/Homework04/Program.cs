/* Есть магазин "Еда"
В магазине есть охранник
Охранник ведёт запись всех, кто заходит в магазин
Охранник ведёт запись всех, кто выходит из магазин

Зайти и выйти можно в целый час.

Выяснить в какой промежуток времени было больше всего
посетителей

Данные вводятся парами: приход-уход
Максимум 100 покупателей

Входные данные
10-12
11-13
9-12

Ответ
11-12 */

int[] time = new int[24]; //так как 24 часа
for (int i = 10; i <= 12; i++)               
{
    time[i] += 1;
}
Console.WriteLine(" Приход покупателей с 10 до 12");
Console.WriteLine(String.Join(" ", time));

int[] time1 = new int[24]; //так как 24 часа
for (int i = 11; i <= 13; i++)               
{
    time1[i] += 1;
}
Console.WriteLine(" Приход покупателей с 11 до 13");
Console.WriteLine(String.Join(" ", time1));

int[] time2 = new int[24]; //так как 24 часа
for (int i = 9; i <= 12; i++)               
{
    time2[i] += 1;
}
Console.WriteLine(" Приход покупателей с 9 до 12");
Console.WriteLine(String.Join(" ", time2));

int[] tout = new int[24]; //так как 24 часа
for (int i = 1; i < 24; i++)               
{
    tout[i] = time1[i] + time2[i] - time[i];
}
Console.WriteLine(" всего");
Console.WriteLine(String.Join(" ", tout));