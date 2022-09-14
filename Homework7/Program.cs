// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// double[,] arr = new double[7, 12];
// void TwoDigitArr()
// {
// Random digit = new Random();
// for (int i = 0; i < 7; i++)
// {
//     for (int j = 0; j < 12; j++)
//     {
//         arr[i, j] = digit.NextDouble() * 100; 
//         // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,6:F2}", arr[i, j]); // 0,6 это расстояние между столбцами
//                                              //  f2 - округление вещественных чисел в массиве
//     }
//     Console.WriteLine();
// }
// }
// TwoDigitArr();

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int rows = 2;
// int columns = 6;

// int [,] NewArray(int m, int n)
// {
//     var result = new int[m,n];
//     for(int i=0;i<m; i++)
//     {
//         for(int j=0;j<n; j++)
//         {
//             result [i,j] = new Random().Next(100);
//         }
//     }
//     return result;
// }

// bool Content(int[,] array, int element)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array [i,j] == element)
//             {
//                 return true;
//             }
//         }
//     }
//     return false;
// }

// void PrintArray(int [,] array)
// {
//      for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write($"{array[i,j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }
// var Array = NewArray(rows,columns);
// PrintArray(Array);
// System.Console.WriteLine(Content(Array, 12));

//  Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.

 int rows = 2;
int columns = 6;

int [,] NewArray(int m, int n)
{
    var result = new int[m,n];
    for(int i=0;i<m; i++)
    {
        for(int j=0;j<n; j++)
        {
            result [i,j] = new Random().Next(100);
        }
    }
    return result;
}

double[] GetAvePerColumn(int[,] array) 
{ 
    var result = new double[array.GetLength(1)]; 
 
    for (int i = 0; i < array.GetLength(1); i++) 
    { 
        double sum = 0; 
 
        for (int j = 0; j < array.GetLength(0); j++) 
        { 
            sum += array[j, i]; 
        } 
        result[i] = Math.Round(sum / array.GetLength(0), 2); 
    } 
    return result; 
} 
 
void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]} "); 
        } 
        System.Console.WriteLine(); 
    } 
} 
 
int[,] arr = NewArray(rows, columns); 
 
PrintArray(arr); 
 
System.Console.WriteLine(); 
 
foreach (var item in GetAvePerColumn(arr)) 
{ 
    System.Console.WriteLine(item); 
}