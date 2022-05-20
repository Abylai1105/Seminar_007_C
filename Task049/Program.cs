// Задача 49: Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса НЕчётные, и замените эти элементы на их квадраты.

// Например, изначально массив             Новый массив будет выглядеть 
// выглядел вот так:                       вот так:
// 1 4 7 2                                 1 4 7 2
// 5 9 2 3                                 5 81 2 9
// 8 4 2 4                                 8 4 2 4

Console.Write("Задайте m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array [i, j] = new Random().Next(1, 11);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine();


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 == 1 && j % 2 == 1 && i != 0 && j != 0) 
        {
            array[i, j] = array[i, j] * array[i, j];
        }  
    }   
}


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}