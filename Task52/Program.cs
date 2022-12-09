//Задача 52. 
//Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}\t");
            else Console.WriteLine($"{matrix[i, j]}");
        }
    }
}

void GetAverage (int[,] matrix)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average += matrix[i, j];
        }
        average = average / 3;
        average = Math.Round(average, 1);
        if(j < matrix.GetLength(1) - 1) Console.Write($"{average}; ");
        else Console.WriteLine($"{average}.");
    }
}


int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);
GetAverage(array2D);