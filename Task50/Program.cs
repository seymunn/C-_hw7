//Задача 50.
//Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1,7 -> такого элемента в массиве нет

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



int[,] array2D = CreateMatrixRndInt(3,4, 0, 30);
PrintMatrix(array2D);

Console.WriteLine("Введите первое число:");
int firstpos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondpos = Convert.ToInt32(Console.ReadLine());

Console.Write($"{firstpos}, {secondpos} -> ");
Console.WriteLine(firstpos < 3 & secondpos < 4
     ? $"{array2D[firstpos, secondpos]}" 
     : "такого элемента в массиве нет");