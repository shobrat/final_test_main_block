﻿// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
// 5 12 16 q [STOP] 3 45 342 15 [STOP]


using System;

class Program
{

    // public string EqualsQ()
    // {
    //     string q = "q";
    //     return q;
    // }
    public static int Main()
    {
        /*переменная, которой потом присвоим значение этой суммы, 
        должна сразу быть инициализирована нулем*/
        double res = 0;
        //string qu = "q";
        int stringToInt = Convert.ToInt32("q");
        for (; ; )
        {
            Console.Write("Введите число, для выхода введите 0 : ");
            double num = double.Parse(Console.ReadLine());
            //int num = Convert.ToInt32(Console.ReadLine());
            // string? num = Console.ReadLine();

            if (num == 0)
            {
                break;
            }
            res += num;
            
            if (num == stringToInt)
            {
                break;
            }
            

        }
        Console.WriteLine("\nСумма : {0}", res);
        Console.ReadKey();
        return 0;
    }


}

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





