// Написать программу, которая выводит случайное число из отрезка [10, 99]  и показывает наибольшую цифру числа.
//например:
//78 -> 8
//12 -> 2
// 85 -> 8
int num =new Random().Next(10,100);
Console.WriteLine( $"было с генерировано случайное число (num)");
int x1= num/10;
int x2 = num%10;
if (x1>x2)
System.Console.WriteLine($" наибольшая цифра этого числа это (x1)");
else if (x1<x2)
System.Console.WriteLine($" наибольшая цифра этого чила это (x2)");
else 
System.Console.WriteLine("обе цифры этого числа равны");

