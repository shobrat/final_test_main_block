﻿// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
// 5 12 16 q [STOP] 3 45 342 15 [STOP]

using System;
class Program
{
    static void Main()
    {
        while (true) // Бесконечный цикл
        {
            Console.Write("Введите число или 'q' для выхода: ");
            string input = Console.ReadLine(); // Чтение строки ввода пользователя
            if (input == "q") // Проверка на ввод 'q' для выхода
            {
                break;
            }
            int number;
            if (int.TryParse(input, out number)) // Проверка, является ли ввод числом Метод int.TryParse используется для попытки 
            //преобразования строки в целое число типа int. Первый аргумент input представляет собой строку для преобразования, 
            //а второй аргумент out int number - это переменная, в которую будет сохранено преобразованное значение.
            //- out: Ключевое слово out указывает, что аргумент number передается по ссылке, а не по значению. 
            //Это означает, что метод int.TryParse может изменить значение переменной number внутри себя 
            //(если преобразование произошло успешно), и эти изменения будут видны в основной функции.й функции.
            //Иными словами, после выполнения метода int.TryParse, переменная number будет содержать преобразованное значение 
            //из строки input в целое число типа int,
            {
                int sum = 0;
                while (number > 0) // Вычисление суммы цифр числа
                {
                    sum += number % 10; // Добавление последней цифры к сумме
                    number /= 10; // Удаление последней цифры из числа
                }
                if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
                {
                    Console.WriteLine("[STOP]");
                    break;
                }
            }

            else // Если ввод не является числом и не 'q', повторить запрос
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
            }
        }
    }
}


// using System;

// class Program
// {
//     static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("Введите целое число или 'q' для выхода:");
//             string input = Console.ReadLine();

//             if (input.ToLower() == "q")
//             {
//                 Console.WriteLine("Программа завершена.");
//                 break;
//             }

//             if (int.TryParse(input, out int number))
//             {
//                 int sum = CalculateDigitSum(Math.Abs(number));

//                 if (sum % 2 == 0)
//                 {
//                     Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
//                     break;
//                 }
//             }
//         }
//     }

//     // Метод для вычисления суммы цифр числа
//     static int CalculateDigitSum(int num)
//     {
//         int sum = 0;
//         while (num != 0)
//         {
//             sum += num % 10;
//             num /= 10;
//         }
//         return sum;
//     }
// }


// /*переменная, которой потом присвоим значение этой суммы, 
// должна сразу быть инициализирована нулем*/
// double res = 0;
// //string qu = "q";
// int stringToInt = Convert.ToInt32("q");
// for (; ; )
// {
//     Console.Write("Введите число, для выхода введите 0 : ");
//     double num = double.Parse(Console.ReadLine());
//     //int num = Convert.ToInt32(Console.ReadLine());
//     // string? num = Console.ReadLine();
//     if (num == 0)
//     {
//         break;
//     }
//     res += num;

//     if (num == stringToInt)
//     {
//         break;
//     }
// }
// Console.WriteLine("\nСумма : {0}", res);
// Console.ReadKey();
// return 0;

// Console.WriteLine("Введите целое число, если хотите завершить: введите q или число, сумма которого четная");
// int num = Convert.ToInt32(Console.ReadLine());


// int CreateNewArray(int count)
// {
//     int sum = 0;
//     int[] array = new int[count];
//     for (int i = 0; i < array.Length; i++)
//     {
//         sum = array[i] + array[i];
//         //Console.WriteLine(array[i]);
//     }
//     return sum;
// }

// public static int CountEvenItems(int[] numbers)
//     {
//         int count =0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] % 2 == 0)
//             {
//                 count++; 
//             }
//         }
//         return count;
//     }

// int result = CreateNewArray(num);
// Console.Write(result);



// int size = 100;
// int[] arr_int = new int[size];
// int i = 0;
// int sum = i / 10 + i % 10;

// while (i < size)
// {
//     Console.WriteLine("Введите целое число, если хотите завершить: введите q или число, сумма которого четная");
//     string input = Console.ReadLine();
//     arr_int[i] = Convert.ToInt32(input);
//     i = i + 1;

//     string q = Console.ReadLine();

//     if (q == "stop") break;

//     if (sum % 2 == 0) Console.WriteLine($"{sum}"); break;
// }



// да в первой задаче надо проверять на
// а) что бы в string не попало нулабельное значение
// 6) что бы был выход, когда будет "q"
// в) если не попадает в первые два случая, пробуем конвертировать в число, если получается, то считаем сумму цифр и проверяем на четность
// г) если не получается, значит там строка, просто выводим ее в консоль





