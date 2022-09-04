/*// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.WriteLine("Enter number...");
void Progressive()
{
    Console.WriteLine("number A");
    int numberA = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("number B");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int result = numberA;
   for(int i=1; i<= numberB;i++)
   {
       result *= numberA;
       Console.WriteLine(result);      
   }
   Console.WriteLine(result);
}
Progressive();*/

 /* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
 //цифр в числе.



int SummDigits (string number)
{     
   int summ = 0;
   
   for(int i=0;i < number.Length; i++)
   {
       summ = summ + Convert.ToInt32(Char.GetNumericValue(number[i]));
   }
   return summ;
}

Console.WriteLine("Enter number...");
int SumNumber = SummDigits(Console.ReadLine());
Console.WriteLine($"Summ of digits of this number is {SumNumber}");*/

// Напишите программу, которая задаёт массив из введенного числа и выводит их на экран,
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение, 
// надо заполнить массив рандоными данными от минимального до максимального значение.
// И важное уточнениее , делать все в методе который возвращает массив.

int[] MaxMinArray()
{
    Console.Write("Введите размер массива...");
    int Size = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    int[] arr = new int[Size];

    Console.Write("Введите минимальное значение массива...");
    int minNum = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите максимальное значение массива...");
    int maxNum = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i <= Size - 1; i++)
    {
        if (minNum <= maxNum) arr[i] = new Random().Next(minNum, maxNum + 1);
        else arr[i] = new Random().Next(maxNum, minNum + 1);
    }

    return arr;
}

void SortAndPrintArray(int[] cheking)
{
    for (int i = 0; i < cheking.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < cheking.Length; j++)
        {
            if (cheking[min] > cheking[j]) min = j;
        }

        int go = cheking[min];
        cheking[min] = cheking[i];
        cheking[i] = go;

        if (i == cheking.Length - 1) Console.Write($"{cheking[i]} ");
        else Console.Write($"{cheking[i]}, ");
    }
}

int[] array = MaxMinArray();
SortAndPrintArray(array);







  


