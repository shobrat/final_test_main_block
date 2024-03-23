
// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите два неотрицательных числа m и n:");

int m = Convert.ToInt32(Console.ReadLine()!);
int n = Convert.ToInt32(Console.ReadLine()!);

int result = AckFunction(n, m);
Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n} -> {result}");

int AckFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AckFunction(n - 1, 1);
    }
    else
    {
        return AckFunction(n - 1, AckFunction(n, m - 1));
    }
}
