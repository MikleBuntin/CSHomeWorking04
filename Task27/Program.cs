﻿//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int temp = number;
int sum = 0;
while(temp > 9)
{
    sum = sum + temp % 10;
    temp = temp / 10;

}
sum = sum + temp % 10;

Console.WriteLine(sum);