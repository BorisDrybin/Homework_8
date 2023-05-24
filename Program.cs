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


Console.WriteLine("Введите количество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int [rows, columns];

void GetArray()
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray()
{
   for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumRow(int[,] array)
{
    int minSum = 0;
    int index = 0;

    for(int i = 0; i < arr.GetLength(0); i++)
        {
            int sum = 0;

            for(int j = 0; j < arr.GetLength(1); j++)
                {
                    sum = sum + arr[i, j];
                }
            if(i == 0)
                {
                    minSum = sum;
                }
            else if(sum < minSum)
                {
                    minSum = sum;
                    index = i;
                }
        }
        Console.WriteLine("Номер строки с минимальной суммой: " +(index + 1));
}

GetArray();
PrintArray();
SumRow(arr);