﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array = Generate3DArray(2, 2, 2);
PrintArray(array);

int[,,] Generate3DArray(int m, int n, int l) // Создает трехмерный массив
{
    int[,,] array = new int[m, n, l];

    Random random = new Random();
    int counter = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                array[i, j, k] = counter;
                counter += 3;
            }

        }
    }
    return array;
}

void PrintArray(int[,,] array) // Печатает трехмерный массив
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"<{array[i, j, k]}> ({i}, {j}, {k})");
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}