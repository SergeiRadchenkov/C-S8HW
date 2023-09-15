/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(1, 10);
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

int[] SumRows(int[,] array)
{
    int sum = 0;
    int row = 0;
    int[] newArray = new int[array.GetLength(0)];
    while (row < array.GetLength(0))
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum = sum + array[row, i];
        }
        newArray[row] = sum;
        sum = 0;
        row++;
    }
    return newArray;
}

void SortArray(int[] array)
{
    int min = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            count = i + 1;
        } 
    }
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] == array[count - 1]) // Данный цикл показывает несколько 
        {                                 // одинаковых минимальных сумм строчек
            if (j == count - 1)
            {
                continue;
            }
            else
            {
                Console.WriteLine($"Строка {j + 1} с наименьшей суммой элементов и");
            }
        }
    }
    Console.WriteLine($"Строка {count} с наименьшей суммой элементов");
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столцов: ");
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray);
Print2DArray(myArray);
int[] newAr = SumRows(myArray);
Console.WriteLine();
SortArray(newAr);