// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Console.WriteLine("Введите целые числа");
int num = Convert.ToInt32(Console.ReadLine());



static int CountSumNumbers(int num)
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

int[] BreakEnterNumbers(int[] array)
{
    i=0;
    while(true)
    {
        i++;
        Console.WriteLine(i);
    }
}

BreakEnterNumbers(num);

int result = CountSumNumbers(num);

Console.WriteLine($"{result}");


static void Main(string[] args)
        {
            int i = 0;
            for (; ; )
            {
                i++;
                Console.WriteLine(i);
                if (i==12345) break;
            }
            Console.ReadLine();
        }



// int BreakEnterNumbers(int num)
// {
//     int number=0;
// }