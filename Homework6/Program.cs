// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int CountPositivEnteredNumbers(int countOfNumbers) // первый вариант ввода чисел
// {
//     Console.WriteLine($"Введите {countOfNumbers} целых чисел...");

//     int[] arrayEnteredNumbers = new int [countOfNumbers];
//     int count=0;

//     for (int i = 0; i < countOfNumbers; i++)
//     {
//         arrayEnteredNumbers[i] = Convert.ToInt32(Console.ReadLine()); 
//         if(arrayEnteredNumbers[i]> 0)
//         {
//             count++;
//         } 

//     }


//     Console.WriteLine($"Введённые числа: {String.Join(", ", arrayEnteredNumbers)}");
    
//     return count;
// }
// Console.WriteLine(CountPositivEnteredNumbers(10)); 


// void EnteredNumbersFromUser() // второй вариант ввода чисел
// {
//     Console.Write("Введите элементы(через пробел): ");

//     int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // Разделяем строку 
//     //на несколько или один разделитель, то есть поэлементно.
//     int count = 0;
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             count++;
//         }
//     }
    
//     Console.WriteLine($"Кол-во элементов > 0: {count}");
// }




// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
double x = (b1 - b2)/(k2 - k1);
double y = k1 * x + b1;
 
// x = Math.Round(x, 3); // для того что б округлитьб обрезала f3//
// y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x:f3};{y:f3})");

