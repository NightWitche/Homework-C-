
/*// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] array = new int[10];

// void EvenNumbersArray(int[] arr)
// {
// int count = 0;

// for(int i = 0; i < array.Length; i++)
// {
//   arr [i]=new Random().Next(100,1000);

//     if(arr[i]%2 == 0)
//     {
//         count++;
//     }
// }
//  Console.WriteLine(string.Join(",", array));
//  Console.WriteLine(count);
// }
// EvenNumbersArray(array);

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];

void NotEvenPosArray (int[] arr)
{
    int SummPozIndArray = 0;
    for(int i = 0; i < array.Length; i++)
  {
     arr [i]=new Random().Next(15);

      //if(i % 2!= 0) - если складывать нечетный индекс элемента в массиве
      if(i % 2 == 0) // если нечетную позицию.
      {
        SummPozIndArray+=arr[i];
      }
         
  }

 Console.WriteLine(string.Join(",", array));
 Console.WriteLine(SummPozIndArray);
}
NotEvenPosArray(array);*/

// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

double[] array = new double[15];
void MinMaxArray(double[] arr)
{
  double MinNum= 0;
  double MaxNum= 0;
  
  for(int i = 0; i < arr.Length; i++)
 {
    arr[i] = new Random().Next(-5,25);
    Console.Write(arr[i]+" ");
 }
   for (int i = 1; i < arr.Length; i++)
 {
    if (arr[i] < MinNum) MinNum = arr[i];
    if (arr[i] > MaxNum) MaxNum = arr[i];
     
 }
     Console.WriteLine($"Min number array {MinNum}\nMax number array {MaxNum}");
     Console.WriteLine($"{MaxNum - MinNum}");
}
MinMaxArray(array);

