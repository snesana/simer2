﻿//Напишите программу,которая принимает на входе число и проверяет ,кратно ли оно одновременно 7 и 23.
// 14->нет
//46-> нет
//161->да
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num% 7==0 && num%23==0)
System.Console.WriteLine($"{num}оно кратно 7 и 23");
else 
System.Console.WriteLine($"{num} оно не кратно 7 и 23");