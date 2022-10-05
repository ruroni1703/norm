// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int GetValue(int min, int max) //Заполнение рандомными числами 
{ 
    return new Random().Next(min, max); 
} 
 
int[] CreateArray(int size)  //инициализируем массив 
{ 
    return new int[size]; 
} 
 
void FillArray(int[] array)//заполняем массив 
{ 
    int size = array.Length; 
    for (int index = 0; index < size; index++) 
    { 
        array[index] = GetValue(-100, 101); 
    } 
} 
 
string Print(int[] array) //выводим полученный массив на экран 
{ 
    return "[" + String.Join(',', array) + "]"; 
}


int[] size = CreateArray( 15);
FillArray(size);
Print(size);




