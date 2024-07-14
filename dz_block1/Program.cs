using System;

public class FindStrings
{
    public static void Main(string[] args)
    {
        // Ввод строк
        string[] Array = { "Hello", "2", "world", ":-)" };
        
        // размер нового массива
        int count = 0;
        foreach (string str in Array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // новый массив
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

        // Вывод
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
