/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns * 2];
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
    int row = 0;
    while (row < array.GetLength(0))
    {
        Console.Write("|\t");
        for (int i = 0; i < array.GetLength(1) / 2; i++)
        {
            Console.Write($"{array[row, i]}\t");
        }
        Console.Write("|\t");
        for (int i = array.GetLength(1) / 2; i < array.GetLength(1); i++)
        {
            Console.Write($"{array[row, i]} \t");
        }
        Console.Write("|\t");
        row++;
        Console.WriteLine();
    }
}

int[,] MultiMatrix(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1) / 2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) / 2; j++)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                newArray[i, j] += array[i, k] * array[k, j + array.GetLength(1) / 2];
            }
        }
    }
    return newArray;
}

void Print2DArray2(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Результат сложения матриц: ");
    int row = 0;
    while (row < array.GetLength(0))
    {
        for (int i = 0; i < array.GetLength(1) / 2; i++)
        {
            Console.Write($"{array[row, i]}\t");
        }
        for (int i = array.GetLength(1) / 2; i < array.GetLength(1); i++)
        {
            Console.Write($"{array[row, i]}\t");
        }
        row++;
        Console.WriteLine();
    }
}

int size = InputNum("Задайте размерность матриц: ");
int[,] myArray = Create2DArray(size, size);
Fill2DArray(myArray);
Print2DArray(myArray);
int[,] newAr = MultiMatrix(myArray);
Print2DArray2(newAr);