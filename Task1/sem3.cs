/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

*/
/*
int[] myArray = new int[5];
Random rand = new Random();
int count = 0;
for (int i = 0; i < myArray.Length; i++)
    myArray[i] = rand.Next(100, 300);

for (int z = 0; z < myArray.Length; z++)
if (myArray[z] % 2 == 0)
count++;
void PrintArray(int[] myArray)
{
    Console.Write("[ ");
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
PrintArray(myArray);
Console.WriteLine($"Количество чётных чисел в массиве: {count}");
*/
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/
/*
int[] myArray = new int[5];
Random rand = new Random();
int sum = 0;
for (int i = 0; i < myArray.Length; i++)
    myArray[i] = rand.Next(100, 300);

for (int z = 0; z < myArray.Length; z+=2)
    sum = sum + myArray[z];
void PrintArray(int[] myArray)
{
    Console.Write("[ ");
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
PrintArray(myArray);
 Console.WriteLine($"всего {myArray.Length} чисел, сумма элементов на нечётных позициях = {sum}");
 */
 /*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/
/*
int[] myArray = new int[5];
 Random rand = new Random();
for (int i = 0; i < myArray.Length; i++)
    myArray[i] = rand.Next(100, 300);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < myArray.Length; z++)
{
    if (myArray[z] > max)
        {
            max = myArray[z];
        }
    if (myArray[z] < min)
        {
            min = myArray[z];
        }
}

Console.WriteLine($"всего {myArray.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
*/