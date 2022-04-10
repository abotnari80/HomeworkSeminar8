// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

int[,] array = new int[3, 4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = new Random().Next(1, 20);
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}

int max, variable;
System.Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        max = j;
        for (int m = j; m < 4; m++)
            if (array[i, m] > array[i, max]) max = m;

        variable = array[i, j];
        array[i, j] = array[i, max];
        array[i, max] = variable;
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
}