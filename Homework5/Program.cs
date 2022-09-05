
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