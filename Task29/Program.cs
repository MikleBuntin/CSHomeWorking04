//Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

// Не вполне понятно что такое "задаёт массив".
// Если генератором, то нужны пределы значений.
// А если запрашивает - вопрос в каком виде.

// Будем решать задачу такую:
// Напишите программу, которая запрашивает размер массива, 
//заполняет массив случайными значениями в диапазоне от 0 до 99 и выводит его на экран.

Console.WriteLine("Введите размер массива: ");
int arrLen = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrLen];

void FloodArray(int[] array)
{
    int i = 0;
    while(i < array.Length)
    //for(int i = 0; i < arrLength; i++)
    {
        array[i] = new Random().Next(0, 100);
        //Console.WriteLine(array[i]);
        i++;
    }
}

void PrintArray(int[] array)
{
    int i = 0;
    Console.Write($"[");
    while(i < array.Length -1)
    {
        Console.Write(array[i] + $", ");
        i++;
    }
    Console.WriteLine(array[i] + $"]");
}

FloodArray(array);
PrintArray(array);