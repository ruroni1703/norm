// Напишите метод, который заполняет массив случайным количеством (от 1 до 100) 
// нулей и едениц. Размер массива должен совпадать с квадратом количества едениц в нем


Random random = new Random();
int countOnes = random.Next(1,11); // создаем переменую количества едениц
Console.WriteLine("Количество едениц" + countOnes);
int size = countOnes * countOnes; //размер равен квадрату количества едениц
int[] numbers = new int[size];

for (int i = 0; i < countOnes; i++)
{
    int randomIndex = random.Next(0, size);
    while (numbers[randomIndex] == 1)
    {
        Console.WriteLine($"Элемент {randomIndex + 1} уже равен 1, ищем следующий");
        randomIndex = random.Next(0, size);
    }
    numbers[randomIndex] = 1;
    Console.WriteLine($"Элемент {randomIndex + 1} стал 1");
}
PrintArray(numbers);

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива ");
    Console.WriteLine("[" + String.Join(",", array) + "]");

}