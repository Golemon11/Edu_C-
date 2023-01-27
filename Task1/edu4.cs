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
/*
int[] array = new int[3];
Console.WriteLine("Введите 8 чисел.");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите [{i}]: ");
    array[i] = int.Parse(Console.ReadLine());
}
var str = string.Join(" ,", array);
Console.WriteLine($"[{str}]");
*/