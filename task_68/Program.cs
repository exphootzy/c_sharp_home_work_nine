// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Start(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int AkkermanFuncion(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return AkkermanFuncion(m - 1, 1);
  else return AkkermanFuncion(m - 1, AkkermanFuncion(m, n - 1));
}

Console.Clear();

int m = Start("Введите параметр m: ");
int n = Start("Введите параметр n: ");

Console.WriteLine($"A({m},{n}) = {AkkermanFuncion(m, n)}");