// Задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

// Console.Write("Enter first number..."); 
// int Number1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Enter second number..."); 
// int Number2 = Convert.ToInt32(Console.ReadLine()); 
// int max = 0;

// if (Number1 > Number2)
// {
//     max = Number1;
// }
// else
// {
//     max = Number2;
// }
// Console.WriteLine("max" + max);

// Задача 4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

// double Number1 = new Random().Next(); 
// Console.WriteLine(Number1); 
// double Number2 = new Random().Next(); 
// Console.WriteLine(Number2); 
// double Number3 = new Random().Next(); 
// Console.WriteLine(Number3); 
// double MaxNumber = Number1; 

// if (Number2 > MaxNumber) 
// { 
//     MaxNumber = Number2; 
// } 
// if (Number3 > MaxNumber) 
// { 
//     MaxNumber = Number3; 
// } 
// Console.Write("Max number is " + MaxNumber);

//Задача 6: 
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

//Console.Write("Enter number...");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number % 2 == 0)
//{
//  Console.WriteLine("NumberEven");
//}
// else
// {
//     Console.WriteLine("NumberNotEven");
// }    
      
// Задача 8
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter a number..."); 
int OverNumber = Convert.ToInt32(Console.ReadLine()); 
int StartNumber = 1; 
while (StartNumber <= OverNumber) 
{ 
    if (StartNumber % 2 == 0) 
    { 
        Console.Write(StartNumber + " "); 
    } 
    StartNumber = StartNumber+1; 
}
