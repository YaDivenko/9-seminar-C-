//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

System.Console.Write("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());
NumRec(n);

void NumRec(int n, int a = 1)
{
if (a > n) return;
else System.Console.Write($"{n} ");
NumRec(n-1, a);
}