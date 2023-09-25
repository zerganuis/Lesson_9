/*
 Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 N = 5. -> "5, 4, 3, 2, 1"
 N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
 */



int InputNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
void PrintNumbers(int n, int count)
{
      if (count > n)
    {
        return;
    }
    else
    {
        PrintNumbers(n, count + 1);
        Console.Write(count + " ");
    }
}
int number = InputNum("Введите число: ");
int count = 1;
PrintNumbers(number, count);


 /*
 Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 M = 1; N = 15 -> 120
 M = 4; N = 8. -> 30
 */
 
int InputNumM(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
// функция сумма чисел от M до N
int SumMN(int num1, int num2)
{
    int res = num1;
    if (num1 == num2)
        return 0;
    else
    {
        num1++;
        res = num1 + SumMN(num1, num2);
        return res;
    }
}
// Принт функции "сумма чисел от M до N"
void SumFromMToN(int num1, int num2)
{
    Console.Write(SumMN(num1 - 1, num2));
}
int firstNum = InputNumM("Введите число M: ");
int secondNum = InputNumM("Введите число N: ");
SumFromMToN(firstNum, secondNum);


/*
 Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 m = 2, n = 3 -> A(m,n) = 9
 m = 3, n = 2 -> A(m,n) = 29
 */
 
int InputNumM(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
// Принт функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}
// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
int firstNum = InputNumM("Введите число M: ");
int secondNum = InputNumM("Введите число N: ");
AkkermanFunction(firstNum, secondNum);