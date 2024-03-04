// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [344 452 341 125] => 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int FindEvenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += 1;
        }
    }
    return sum;
}

int minimum = 100;
int maximum = 1000;
int count = 25;

int[] array = CreateArrayRndInt(count, minimum, maximum);
PrintArray(array);

Console.WriteLine($" => {FindEvenNumbers(array)}");

// Console.WriteLine("Введите целые числа");
// int num = Convert.ToInt32(Console.ReadLine());


// int sum = 0;
// int count = num.ToString().Length;
// for (int i = 0; i < count; i++)
// {
//     int del = num % 10;
//     num = num / 10;
//     sum = sum + del;
// }

// Console.WriteLine($"{num} {sum}");