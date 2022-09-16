// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.Clear();
// Console.WriteLine($"\nInput the size Array...:");
// int m = EnterNumbers("Enter m: ");
// int n = EnterNumbers("Enter n: ");
// int Line = EnterNumbers("Enter Range 1 to... ");

// int[,] array = new int[m, n];
// InitArray(array);
// WriteArray(array);

// Console.WriteLine($"\nSorted array...: ");
// LocArrLines(array);
// WriteArray(array);

// void LocArrLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// int EnterNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void InitArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(Line);
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

// Console.Clear();
// Console.WriteLine($"\nInput the size Array...:");
// int m = EnterNumbers("Enter m: ");
// int n = EnterNumbers("Enter n: ");
// int Line = EnterNumbers("Enter Range 1 to... ");

// int[,] array = new int[m, n];
// InitArray(array);
// WriteArray(array);

// int minSumRows = 0;
// int sumRows = SumRowsElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumRows = SumRowsElements(array, i);
//   if (sumRows > tempSumRows)
//   {
//     sumRows = tempSumRows;
//     minSumRows= i;
//   }
// }

// Console.WriteLine($"\n{minSumRows+1} - sttring min summ ({sumRows}) elements ");


// int SumRowsElements(int[,] array, int i)
// {
//   int sumRows = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumRows += array[i,j];
//   }
//   return sumRows;
// }

// int EnterNumbers(string enter)
// {
//   Console.Write(enter);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void InitArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(Li);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

 //Задайте две матрицы. Напишите программу, которая будет находить 
 //произведение двух матриц.

//  Console.Clear();
// Console.WriteLine($"\nEnter size matrix and range of random numbers:");
// int a = EnterNumbers("Enter numbers the rows first matrix: ");
// int b = EnterNumbers("Enter numbers the columns first matrix(and rows second matrix): ");
// int c = EnterNumbers("Enter numbers the columns second matrix: ");
// int Line = EnterNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[a, b];
// InitArray(firstMartrix);
// Console.WriteLine($"\nFirst matrix:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[b, c];
// InitArray(secomdMartrix);
// Console.WriteLine($"\nSecond matrix:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[a,c];

// MultMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"\nMultiplication first matrix on second matrix:");
// WriteArray(resultMatrix);

// void MultMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int EnterNumbers(string enter)
// {
//   Console.Write(enter);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void InitArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(Line);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

// Console.Clear();
// Console.WriteLine($"\nEnter size array X x Y x Z:");
// int x = EnterNumbers("Enter X: ");
// int y = EnterNumbers("Enter Y: ");
// int z = EnterNumbers("Eneter Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// InitArray(array3D);
// WriteArray(array3D);

// int EnterNumbers(string enter)
// {
//   Console.Write(enter);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void InitArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }

//Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int n = 4;
int[,] fillingMatrix = new int[n, n];

int count = 1;
int i = 0;
int j = 0;

while (count <= fillingMatrix.GetLength(0) * fillingMatrix.GetLength(1))
{
  fillingMatrix[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < fillingMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= fillingMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > fillingMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(fillingMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}