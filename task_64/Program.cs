// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int Start(string message)
{
  System.Console.WriteLine(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int PrintNumber(int i, int j)
{
  if (i == j) return i;
  else Console.Write($"{PrintNumber(i, j + 1)}, ");
  return j;
}

Console.Clear();
int i = Start("Введите число: ");
System.Console.WriteLine($"Числа от {i} до 1: ");
System.Console.WriteLine(PrintNumber(i, 1));
