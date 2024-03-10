//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
//"aBcD1ef!" => Нет
//"шалаш" => Да
//"55655" => Да


Console.WriteLine("Введите произвольную строку");
string letters = Console.ReadLine();

char[] let = letters.ToCharArray();

static bool IsPalindrom(char[] word)
{
    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] != word[word.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

if (IsPalindrom(let)) { Console.WriteLine("=> Да"); }
else { Console.WriteLine("=> Нет"); }


// Задача 3: Проверка строки на палиндром
// public class Task3
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка для проверки
//         string input = "шалаш";
//         // Вызов метода для проверки, является ли строка палиндромомbool isPalindrome = IsPalindrome(input);
//         // Вывод результата
//         Console.WriteLine(isPalindrome ? "Да" : "Нет");
//     }
// // Метод для проверки, является ли строка палиндромомpublic static bool IsPalindrome(string str)
// {
// // Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
// string normalized = new
// string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// // Сравнение строки с ее перевернутым вариантом
// return normalized.SequenceEqual(normalized.Reverse());
// }
// }



// char[] sym = sl.ToCharArray();

//         }

//     }

// void IsLettersEqual(string[] chars)
// {

//     for (int i = 0; i < chars.Length; i++)
//     {
//         if (chars[i] == chars[i - 1])
//         {
//             Console.WriteLine("Да");
//         }
//         else
//         {
//             Console.WriteLine("Нет");
//         }
//     }

// }




// while (true)
// {


//     string[] let = { letters };

//     IsLettersEqual(let);