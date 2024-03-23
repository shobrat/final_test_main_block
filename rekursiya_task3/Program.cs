// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Пример: [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


int[] array = { 1, 2, 5, 0, 10, 34 };

Console.WriteLine("Элементы массива, начиная с конца:");
ArrayFromEnd(array, array.Length - 1);

static void ArrayFromEnd(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write($"{arr[index]} ");
        ArrayFromEnd(arr, index - 1);
    }
}
