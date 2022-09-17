//Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.

//  Console.Clear();
// int n = InputNumber("Enter n");
// int m = InputNumber("Enter m");
// if (n < m)
// {
//     Console.WriteLine(NaturalNumber(n, m));
// }
// Console.WriteLine("error");

// int NaturalNumber(int n, int m)
// {
//     if (n == m)
//         return n;
//     else
//         Console.Write($"{NaturalNumber(n, m - 1)}, ");
//     return m;
// }

// int InputNumber(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

//  Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Clear();

// double m = EnterNumbers("Enter m: ");
// double  n = EnterNumbers("Eneter n: ");
// double  temp = m;

// if (m > n) 
// {
//   m = n; 
//   n = temp;
// }

// PrintSumm(m, n, temp=0);

// void PrintSumm(double  m, double  n, double  summ)
// {
//   summ = summ + n;
//   if (n <= m)
//   {
//     Console.Write($"Сумма элементов= {summ} ");
//     return;
//   }
//   PrintSumm(m, n - 1, summ);
// }

// double EnterNumbers(string enter) 
// {
//   Console.Write(enter);
//   double output = Convert.ToDouble(Console.ReadLine());
//   return output;
// }


////Напишите программу вычисления функции Аккермана с помощью рекурсии. 
////Даны два неотрицательных числа m и n.

Console.Clear();

long m = EnterNumbers("Enter m: ");
long  n = EnterNumbers("Enter n: ");

long  functionAkkerman = Ack(m, n);

Console.Write($"Function the Akkerman = {functionAkkerman} ");

long  Ack(long  m, long n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

long EnterNumbers(string input) 
{
  Console.Write(input);
  long  output = Convert.ToInt64(Console.ReadLine());
  return output;
}
// Работает с числами не больше 4х и я беспонятия как увеличить обьем данных.