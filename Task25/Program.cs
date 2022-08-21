//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

double aPowB(a, b)
{
    int pow = a;
    for(int i = 1; i < b; i++)
    {
        int pow = pow * a;
        
    return(pow);
}

// В задании написано: "и возводит в степень". А выводить не нужно? :)

Console.WriteLine(aPowB(a, b));