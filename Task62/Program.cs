/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int num)
{
    return new int[num, num];
}

void Fill2DArray(int[,] array)
{
    int maxValue = array.Length;
    int minValue = 1;
    int row = 0;
    int column = 0;
    int direct = 0;
    while (minValue <= maxValue)
    {
        array[row, column] = minValue;
        if (direct == 0 && (column >= array.GetLength(0) - 1 || array[row, column + 1] != 0))
        {
            direct = 1;
        }
        else if (direct == 1 && (row >= array.GetLength(0) - 1 || array[row + 1, column] != 0))
        {
            direct = 2;
        }
        else if (direct == 2 && (column <= 0 || array[row, column - 1] != 0))
        {
            direct = 3;
        }
        else if (direct == 3 && (row <= 0 || array[row - 1, column] != 0))
        {
            direct = 0;
        }
        if (direct == 0)
        {
            column++;
        }
        else if (direct == 1)
        {
            row++;
        }
        else if (direct == 2)
        {
            column--;
        }
        else if (direct == 3)
        {
            row--;
        }
        minValue++;
    }
}

void Print2DArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int size = InputNum("Введите размер массива: ");
int[,] myArray = Create2DArray(size);
Fill2DArray(myArray);
Print2DArray(myArray);