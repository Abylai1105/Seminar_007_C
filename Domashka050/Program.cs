// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;
Console.Clear();

Console.Write("Задайте m: ");
int m = int.Parse(ReadLine());
Console.Write("Задайте n: ");
int n = int.Parse(ReadLine());

double[,] array = new double [m, n];

Console.Write("Задайте номер массива: ");
int a = int.Parse(ReadLine());
Console.Write("Задайте номер элемента: ");
int b = int.Parse(Console.ReadLine());


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

if (a <=m && b <= n && a > 0 && b > 0)
{
    Console.WriteLine($"{array[a, b]} ");
}
else
{
    Console.WriteLine("Значения нету ");
}