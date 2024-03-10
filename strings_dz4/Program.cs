// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
//"Hello my world" => "worl my Hello"

Console.WriteLine("Введите предложение");
string str = Console.ReadLine();

string[] strArray = str.Split();

void ChangeWorsdsPlace(string[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        string word = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = word;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

ChangeWorsdsPlace(strArray);
PrintArray(strArray);


// Задача 4 (необязательная): Обратный порядок слов в строкеpublic class Task4
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка со словами, разделенными пробелами
//         string input = "Hello my world";
//         // Вызов метода для обращения порядка слов в строке
//         string result = ReverseWords(input);
//         // Вывод результата
//         Console.WriteLine(result);
//     }
//     // Метод для обращения порядка слов в строке
//     public static string ReverseWords(string str)
//     {
//         // Разделение строки на слова
//         string[] words = str.Split(' ');
//         // Обращение порядка слов
//         Array.Reverse(words);
//         // Соединение слов обратно в строку с пробелами
//         return string.Join(" ", words);
//     }
// }