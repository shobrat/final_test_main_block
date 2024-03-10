// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]



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

void ArrayReplacement(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = tmp;
    }
}

int minimum = 1;
int maximum = 10;
int count = 6;

int[] array = CreateArrayRndInt(count, minimum, maximum);
Console.Write($"[ ");
PrintArray(array);
Console.Write($"]");

ArrayReplacement(array);
Console.Write($" => ");

Console.Write($"[ ");
PrintArray(array);
Console.Write($"]");


// Задача 3: Реверсирование одномерного массива
// using System;
// class Program
// {
// static void Main()
// {
// int[] numbers = {1, 3, 5, 6, 7, 8}; // Исходный массив
// int temp;
// // Вывод исходного массива
// Console.Write("Исходный массив: ");
// foreach (int number in numbers)
// {
// Console.Write(number + " ");
// }
// // Реверсирование массива
// for (int i = 0; i < numbers.Length / 2; i++)
// {
// // Меняем местами элементы
// temp = numbers[i];
// numbers[i] = numbers[numbers.Length - 1 - i];
// numbers[numbers.Length - 1 - i] = temp;
// }
// // Вывод измененного массива
// Console.Write("\nПеревернутый массив: ");
// foreach (int number in numbers)
// {
// Console.Write(number + " ");
// }
// }