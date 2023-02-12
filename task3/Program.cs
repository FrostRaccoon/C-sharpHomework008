/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18
*/

int[,] matrix1 = new int[2, 2];
Generate2DArray(matrix1);
Console.WriteLine("Матрица 1: ");
Print2DArray(matrix1);
Console.WriteLine();

int[,] matrix2 = new int[2, 2];
Generate2DArray(matrix2);
Console.WriteLine("Матрица 2: ");
Print2DArray(matrix2);
Console.WriteLine();

int[,] resultMatrix = new int[2, 2];

ProductOfMatrix(matrix1, matrix2, resultMatrix);
Console.WriteLine($"Произведение двух матриц: ");
Print2DArray(resultMatrix);

void ProductOfMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{ 
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j]; 
            }
            resultMatrix[i, j] = sum;
        }
    }
}


void Generate2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

}