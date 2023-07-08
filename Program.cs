using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
namespace HomeworkForTheSecondLecture
{
    class Program
    {
        static void Main(string[] args)//Что бы запустить определенную задачу, раскомментируй нужный task :)
        {
            //task10();
            //task13();
            //task15();
        }
        static void task10()
        // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        // 456 -> 5
        // 782 -> 8
        // 918 -> 1
        {
            Console.Write("напишите трёхзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 99 && a < 1000)
            {
                int a2 = (a % 100) / 10;
                Console.WriteLine(a2);
            }
            else Console.WriteLine("некорректное число");
        }

        static void task13()
        /*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
          645 -> 5
          78 -> третьей цифры нет
          32679 -> 6*/
        {
            int a = new Random().Next();
            // Console.Write("Введите заданное число: ");
            // long a = Convert.ToInt32(Console.ReadLine()); -- Для возможности вводить самому
            int b = a;
            if (a >= 100)
            {
                while (a > 999)
                {
                    a = a / 10;
                }
                int result = a % 10;
                Console.WriteLine($"{b} -> {result}");
            }
            else Console.WriteLine($"{b} -> третьей цифры нет");
        }

        static void task15()
        // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        // 6 -> да
        // 7 -> да
        // 1 -> нет
        {
            Console.Write("напишите цифру: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 5 && a >= 1) Console.WriteLine($"{a} -> нет");
            if (a == 6 || a == 7) Console.WriteLine($"{a} -> да");
            if (a > 7 || a < 1) Console.WriteLine("такого дня недели нет");
        }

    }
}
