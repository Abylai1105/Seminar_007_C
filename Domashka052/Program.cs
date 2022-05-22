// Задача 52: Задайте двумерный массив из целых чисел. 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

using System;
using static System.Console;
Console.Clear();

Console.Write("Задайте m: ");
int m = int.Parse(ReadLine());
Console.Write("Задайте n: ");
int n = int.Parse(ReadLine());

double[,] array = new double [m, n];

Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(0,20);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine();

double [] arr = new double[n];
for (int i = 0; i < n; i++)
{
    double sum = 0;
    for (int j = 0; j < m; j++)
    {
        sum = sum + array[j, i];
    }
    arr[i] = sum / m;
    Console.WriteLine($" {arr[i]} ");
}