﻿/// Напишите программу, которая будет принимать на входе два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остак от деления.
// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно

Console.Write("Введите первое число:");
int num1 = Convert.ToInt32 (Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32 (Console.ReadLine());


if (num1 % num2 ==0)
System.Console.Write("кратно");
else
System.Console.Write($"Число {num2} кратно числу {num1}");
