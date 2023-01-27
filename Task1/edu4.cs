/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/
/*
Console.WriteLine("введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int sum = numberA;
for(int i=1; i < numberB; i++)
{
    sum= sum * numberA;
    
}
Console.WriteLine($"Результат: {sum}");
*/
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("сумма чисел = ");
        var n = Convert.ToInt32(Console.ReadLine());
        var sum = 0;
        while(n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine(sum);
    }
}
*/
/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/
/*
int[] array = new int[8];
Console.WriteLine("Введите 8 чисел.");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите [{i}]: ");
    array[i] = int.Parse(Console.ReadLine());
}
var str = string.Join(" ,", array);
Console.WriteLine($"[{str}]");
*/