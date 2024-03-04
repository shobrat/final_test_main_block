// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Console.WriteLine("Введите целые числа");
int num = Convert.ToInt32(Console.ReadLine());



static int FindSumNumbers(int num)
{
    int sum = 0;
    int count = num.ToString().Length;
    for (int i = 0; i < count; i++)
    {
        int del = num % 10;
        num /= 10;
        sum += del;
    }
    return sum;
}

int result = FindSumNumbers(num);

Console.WriteLine($"{result}");


// int BreakEnterNumbers(int num)
// {
//     int number=0;
// }