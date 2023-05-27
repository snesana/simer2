// Напишите программу, которая принимае на входе два числа и проверяет, является ли одно число квадратом другого.
// 5,25- да 
//-4,16 -да
// 25,5 -да
// 8,9 -нет
Console.WriteLine("Ввидите целое число А: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Ввидите целое число B: ");
int num2 = Convert.ToInt32 (Console.ReadLine());
int doubleNum1= num1* num2;
int doubleNum2=num2 * num1;
if (doubleNum1== num2 || doubleNum2==num1)
System.Console.WriteLine("Да");
else
System.Console.WriteLine("Нет");

