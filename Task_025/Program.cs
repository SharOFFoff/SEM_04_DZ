// Task_025
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("Введите число A: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int m = Convert.ToInt32(Console.ReadLine()), sum = n;

for(int i = 2; i <= m; i++)
    sum = (sum * n);

Console.Write($"Результат: {sum}");
