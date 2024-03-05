// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
// 5 12 16 q [STOP] 3 45 342 15 [STOP]

int size = 100;
int[] arr_int = new int[size];
int i = 0;
int sum = i / 10 + i % 10;

while (i < size)
{
    Console.WriteLine("Введите целое число, если хотите завершить: введите q или число, сумма которого четная");
    string input = Console.ReadLine();
    arr_int[i] = Convert.ToInt32(input);
    i = i + 1;

    string q = Console.ReadLine();

    if (q == "stop") break;

    if (sum % 2 == 0) Console.WriteLine($"{sum}"); break;
}



// да в первой задаче надо проверять на
// а) что бы в string не попало нулабельное значение
// 6) что бы был выход, когда будет "q"
// в) если не попадает в первые два случая, пробуем конвертировать в число, если получается, то считаем сумму цифр и проверяем на четность
// г) если не получается, значит там строка, просто выводим ее в консоль



































// Console.WriteLine("Введите целые числа");
// int num = Convert.ToInt32(Console.ReadLine());



// static int CountSumNumbers(int num)
// {
//     int sum = 0;
//     int count = num.ToString().Length;
//     for (int i = 0; i < count; i++)
//     {
//         int del = num % 10;
//         num /= 10;
//         sum += del;
//     }
//     return sum;
// }

// int[] BreakEnterNumbers(int[] array)
// {
//     i=0;
//     while(true)
//     {
//         i++;
//         Console.WriteLine(i);
//     }
// }

// BreakEnterNumbers(num);

// int result = CountSumNumbers(num);

// Console.WriteLine($"{result}");


// static void Main(string[] args)
//         {
//             int i = 0;
//             for (; ; )
//             {
//                 i++;
//                 Console.WriteLine(i);
//                 if (i==12345) break;
//             }
//             Console.ReadLine();
//         }



static void Main(string[] args)
        {
            int i = 0;
            for (; ; )
            {
                i++;
                Console.WriteLine(i);
                if (i==12345) break;
            }
            Console.ReadLine();
        }



// int BreakEnterNumbers(int num)
// {
//     int number=0;
// }