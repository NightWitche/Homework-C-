/*// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.WriteLine("Enter number...");

double ATodegree ()
{
    Console.WriteLine("number A");
    double numberA = Double.Parse(Console.ReadLine()); 
    Console.WriteLine("number B");
    double numberB = Double.Parse(Console.ReadLine());
    double result = Math.Pow(numberA,numberB);
    System.Console.WriteLine($"{numberA} degree {numberB}");
    return result;
}
    Console.WriteLine($"{ATodegree():f3}");*/

 /*// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
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

//Напишите программу, которая задаёт массив из введенного числа и выводит их на экран,
//пользователь вводит число элементов в массиве и минимальное, и максимальное значение, 
//надо заполнить массив рандоными данными от минимального до максимального значение.
//И важное уточнениее , делать все в методе который возвращает массив.




  


