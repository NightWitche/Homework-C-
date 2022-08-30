//// Задача 21
////Напишите программу, которая принимает на вход координаты двух 
////точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Enter x1...");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y1...");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter z1...");
// int z1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter x2...");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y2...");
// int y2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter z2...");
// int z2 = int.Parse(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((y2 - y1), 2));
// // Console.WriteLine("длинна отрезка"+result);

// Console.WriteLine($"A ({x1},{y1},{z2}); B ({x2},{y2},{z2}) -> {result}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("Enter number...");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Таблица кубов");

// for(int i = 1;i<=number;i++)
// {
//         Console.WriteLine(Math.Pow(i,3));
//         Console.WriteLine("");
        
// }

/////Задача 19
// //Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// //является ли оно палиндромом.
// //14212 -> нет
// //12821 -> да
// //23432 -> да

int[] arrayPalindrom = {0, 0, 0, 0, 0}; 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[0] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[1] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[2] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[3] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Enter the first number of the array... "); 
arrayPalindrom[4] = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Your array is: " + arrayPalindrom[0] + arrayPalindrom[1] + arrayPalindrom[2] + arrayPalindrom[3] + arrayPalindrom[4]); 
 
if ((arrayPalindrom[0] == arrayPalindrom[4]) && (arrayPalindrom[1] == arrayPalindrom[3])) 
{ 
    Console.WriteLine("This number is palindrome!"); 
} 
else 
{ 
    Console.WriteLine("This number is normal"); 
}
