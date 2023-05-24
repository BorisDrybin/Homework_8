//  Задайте двумерный массив. Напишите программу, которая 
//  упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.WriteLine("Введите количество строк массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int [rows, columns];

// void GetArray()
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray()
// {
//    for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ChangeArray()
// {

//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             for(int k = 0; k < arr.GetLength(1) - 1; k++)
//             {
//                 if(arr[i, k] < arr[i, k + 1])
//                 {
//                     int temp = arr[i, k + 1];
//                     arr[i, k + 1] = arr[i, k];
//                     arr[i, k] = temp;
//                 }
//             }
//         }
        
//     }
// }

// GetArray();
// PrintArray();
// ChangeArray();
// PrintArray();


// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Console.WriteLine("Введите количество строк массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int [rows, columns];

// void GetArray()
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray()
// {
//    for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SumRow(int[,] array)
// {
//     int minSum = 0;
//     int index = 0;

//     for(int i = 0; i < arr.GetLength(0); i++)
//         {
//             int sum = 0;

//             for(int j = 0; j < arr.GetLength(1); j++)
//                 {
//                     sum = sum + arr[i, j];
//                 }
//             if(i == 0)
//                 {
//                     minSum = sum;
//                 }
//             else if(sum < minSum)
//                 {
//                     minSum = sum;
//                     index = i;
//                 }
//         }
//         Console.WriteLine("Номер строки с минимальной суммой: " +(index + 1));
// }

// GetArray();
// PrintArray();
// SumRow(arr);


// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой матрицы");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первой матрицы");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов второй матрицы");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int [rows1, columns1];
int[,] matrix2 = new int [rows2, columns2];
int[,] resultMatrix = new int [rows1, columns2];

void GetMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ProductMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
    if(rows2 != columns1)
    {
        Console.WriteLine("Перемножение матриц невозможно!");
    }
    
    else
    {
        for(int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for(int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;

                for(int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                    resultMatrix[i, j] = sum;
            }
        }
    }
}

GetMatrix(matrix1);
PrintMatrix(matrix1);
GetMatrix(matrix2);
PrintMatrix(matrix2);
ProductMatrix(matrix1, matrix2, resultMatrix);
PrintMatrix(resultMatrix);