//Задача №64.
//Выполнить с помощью рекурсии.
//Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.WriteLine("Задача №64.");
Console.WriteLine("Введите натуральное число больше 1: ");
int n = int.Parse(Console.ReadLine()!);

void NumberCounter (int n)
{
    if (n == 0) 
    return;
    Console.Write("{0,2},",n);
    NumberCounter (n - 1);
}
NumberCounter(n);
Console.WriteLine(" ");

//Задача №66. 
//Выполнить с помощью рекурсии.
//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Задача №66.");
Console.WriteLine("Введите значение M:");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение N:");
int N = int.Parse(Console.ReadLine()!);

void GapNumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    GapNumberSum(M, N, sum);
}
GapNumberSum(M, N, 0);


// Задача №68. 
// Выполнить с помощью рекурсии.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.WriteLine("Задача №68.");
int numberm = InputNumbers("Введите m: ");
int numbern = InputNumbers("Введите n: ");

int functionAkkerman = Ack(numberm, numbern);

Console.WriteLine($"Akkerman (m,n) = {functionAkkerman} ");

int Ack(int numberm, int numbern)
{
  if (numberm == 0) return n + 1;
  else if (numbern == 0) return Ack(numberm - 1, 1);
  else return Ack(numberm - 1, Ack(numberm, n - 1));
}
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}