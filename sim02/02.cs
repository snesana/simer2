﻿// Напишите программу , которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456->46
// 782->72
// 918->98

int num =new Random().Next(100,1000);
Console.WriteLine( $"было с генерировано случайное число {num}");
int x1 = num/100;

int x3 = num%10;
System.Console.WriteLine($"{x1}{x3}");

// Напишите программу, которая будет принимать на входе два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остак от деления.
// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно
