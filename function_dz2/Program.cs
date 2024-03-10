﻿// Задайте массив заполненный случайными трёхзначными числами. 
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



// using System;
// class Program
// {
// static void Main()
// {
// int[] numbers = new int[10]; // Массив для хранения случайных чисел
// Random random = new Random(); // Генератор случайных чисел
// int evenCount = 0; // Счетчик четных чисел
// // Заполнение массива случайными трехзначными числами
// for (int i = 0; i < numbers.Length; i++)
// {
// numbers[i] = random.Next(100, 1000); // Случайное число от 100 до 999
// Console.Write(numbers[i] + " "); // Вывод сгенерированного числа
// // Проверка на четность и увеличение счетчика
// if (numbers[i] % 2 == 0)
// {
// evenCount++;
// }
// }
// // Вывод количества четных чисел в массиве
// Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
// }
// }