/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int num)
{
    return new int[num, num, num];
}

void Fill3DArray(int[,,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
}

void Print3DArray(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");

            }
            Console.WriteLine();
        }
    }
            Console.WriteLine();

}

void PrintMatrix(int[,,] matrix)
{
    Console.WriteLine();        
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i, j, k]}\t");            
            }
        }
        Console.WriteLine();        
    }        
}

int size = InputNum("Введите размер трёхмерного массива: ");
int[,,] myArray = Create3DArray(size);
Fill3DArray(myArray);
PrintMatrix(myArray);
Print3DArray(myArray);