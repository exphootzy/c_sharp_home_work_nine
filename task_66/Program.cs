// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Start(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SummNum(int numOne, int numTwo)
{
    if (numOne == numTwo) return numOne;
    else return SummNum(numOne + 1, numTwo) + numOne;
}

Console.Clear();
int numOne = Start("Введите первое число: ");
int numTwo = Start("Введите второе число: ");
System.Console.Write($"Сумма чисел от {numOne} до {numTwo}: ");
System.Console.Write(SummNum(numOne, numTwo));
