using System;

public class FindStrings
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строки через пробелы:");
        string input = Console.ReadLine();
        string[] Array = input.Split(" ");

        int count = 0;
        foreach (string str in Array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Новый массив
        string[] newArray = new string[count];
        int index = 0;

        // Заполнение
        foreach (string str in Array)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }
        
        // вывод
        Console.Write("[");
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write(newArray[i]);
            if (i < newArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
