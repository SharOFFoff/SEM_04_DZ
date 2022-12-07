// Task_Dop_1220
// Суперсдвиг
// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

// Выходные данные
// В выходной файл OUTPUT.TXT выведите полученную последовательность.

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
  Console.Write($"Введите число {i + 1}: \n");
  array[i] = Convert.ToInt32(Console.ReadLine());  
}
Console.WriteLine("Введите число на которое произвести сдвиг (Вправо - положительное, Влево - отрицательное):");
int m = Convert.ToInt32(Console.ReadLine());

if (m > 0)
{
    while (m > 0)
    {
        int tmp = array [n - 1];
        for (int i = n - 1; i > 0; i--)
        {
            array [i] = array [i - 1];
        }
        array [0] = tmp;
        m = m - 1;
    }
}
else
{
    while (m < 0)
    {
        int tmp = array [0];
        for (int i = 0; i < n - 1; i++)
        {
            array [i] = array [i + 1];
        }
        array [n - 1] = tmp;
        m = m + 1;
    }
}

Console.WriteLine($"[{string.Join(", ", array)}]");