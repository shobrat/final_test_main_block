
Console.WriteLine("Введите целые числа");
int num = Convert.ToInt32(Console.ReadLine());


int sum = 0;
int count = num.ToString().Length;
for (int i = 0; i < count; i++)
{
    int del = num % 10;
    num = num / 10;
    sum = sum + del;
}

Console.WriteLine($"{num} {sum}");