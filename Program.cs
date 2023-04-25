// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] FillArray(int row, int col)
{
    int[,] array = new int[row, col];
    int counter = 1;
    for (int i = 0; i < row; i++)
    {
        array[0, i] = counter;
        counter ++;
    }
    for (int i = 0; i < col; i++)
    {
        array[i+1, col-1] = counter;
        counter ++;
    }

}