// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int Exercise1 (int number)
// {
//     if ((number / 100) == 0)
//         {
//             System.Console.WriteLine("If you see you Number, please, write three digit number");
//             return number;
//         }
//     else if ((number / 1000) == 0)
//     {
//         int number2 = (number / 10) % 10;
//         return number2;
//     }
//     else
//     {
//         System.Console.WriteLine("If you see you Number, please, write three digit number");
//         return number;
//     }
// }
// System.Console.WriteLine("Please, write three digit number");
// int numb = Convert.ToInt32((Console.ReadLine()));
// int result = Exercise1 (numb);
// System.Console.WriteLine(result);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// void Exercise(int numb)
// {
//     if (numb > 999)
//     {
        
//         while (numb > 999)
//         {
//             int remainder1 = numb % 10;
//             int numb1 = numb / 10;
//             int remainder2 = numb1 % 10;
//             int numb2 = numb1 / 10;
//             int remainder3 = numb2 % 10;
//             int numb3 = numb2 / 10;
//             if (numb3 < 1000)
//             {
//                 if (numb1 < 1000)
//                 {
//                     numb = remainder2;
//                 }
//                 else if (numb2 < 1000)
//                 {
//                     numb = remainder3;
//                 }
//                 else if (numb3 < 1000)
//                 {
//                     numb = numb3 % 10;
//                 }
//             }
//             else numb = numb3;
            
//         }

//         System.Console.WriteLine(numb);
//         numb = numb+1000;
//     }
//     if (numb < 100)
//     {
//         System.Console.WriteLine("Third number is missing");
//     }
//     if (numb > 100 && numb < 1000)
//     {
//         int number3 = numb % 10;
//         System.Console.WriteLine(number3);
//     }
// }

// System.Console.WriteLine("Please, write number");
// int userwrite = Convert.ToInt32(Console.ReadLine());
// Exercise (userwrite);


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// void Exercise3 (int day)
// {
//     if (day == 6 || day == 7)
//     {
//         System.Console.Write("Today is day off? - Yes");
//     }
//     else if ( day >0 && day < 6)
//     {
//         System.Console.Write("Today is day off? - No");
//     }
//     else 
//     {
//         System.Console.WriteLine("Please, write number in range 1-7");
//     }
// }

// System.Console.WriteLine("Please, write number in range 1-7");
// int number = Convert.ToInt32(Console.ReadLine());
// Exercise3 (number);
